using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataLibrary.Logic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeID, string firstName,
            string lastName, string emailAddress, string password)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeID,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
                Password = password
            };
            string sql = @"insert into dbo.Employee (EmployeeID, FirstName, LastName, EmailAddress, Password) 
                            values(@EmployeeId, @FirstName, @LastName, @EmailAddress, @Password)";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select Id, EmployeeId, FirstName, LastName, EmailAddress from dbo.Employee;";
            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
        public static int DeleteProduct(int employeeId)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeId
            };
            string sql = @"DELETE FROM dbo.Employee WHERE EmployeeId=@EmployeeId;";
            return SqlDataAccess.DeleteData(sql, data);
        }
        public static int UpdateProduct(int employeeId, string firstame, string lastname, string email, string password)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeId,
                FirstName = firstame,
                LastName = lastname,
                EmailAddress = email,
                Password = password
            };
            string sql = @"update dbo.Employee set FirstName=@FirstName,LastName=@LastName,EmailAddress=@EmailAddress, Password=@Password where EmployeeId=@EmployeeId;";
            return SqlDataAccess.UpdateData(sql, data);
        }
    }
}
