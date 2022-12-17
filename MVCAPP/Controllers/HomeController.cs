using MVCAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.Logic.EmployeeProcessor;
namespace MVCAPP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SignUp()
        {
            ViewBag.Message = "Rejestracja Pracownika";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeModel model)
        {
            if(ModelState.IsValid)
            {
                int recordsCreated = CreateEmployee(model.EmployeeId, model.FirstName, model.LastName, 
                    model.EmailAddress, model.Password);
                return RedirectToAction("Index");
            }

            return View();
        }
        public ActionResult ViewEmployeees()
        {
            ViewBag.Message = "Employees List";
            var data = LoadEmployees();
            List<EmployeeModel> employees = new List<EmployeeModel>();
            foreach(var row in data)
            {
                employees.Add(new EmployeeModel
                {
                    EmployeeId = row.EmployeeId,
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    EmailAddress = row.EmailAddress
                });
            }
            return View(employees);
        }
        public ActionResult Delete()
        {
            ViewBag.Message = "Usuń Pracownika";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EmployeeModel model)
        {
            int rec = DeleteProduct(model.EmployeeId);
            return RedirectToAction("Index");
        }
        public ActionResult Update()
        {
            ViewBag.Message = "Aktualizuj pracownika";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(EmployeeModel model)
        {
            int rec = UpdateProduct(model.EmployeeId, model.FirstName, model.LastName,model.EmailAddress ,model.Password);
            return RedirectToAction("Index");
        }
    }
}