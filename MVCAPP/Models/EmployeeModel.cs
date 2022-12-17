using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAPP.Models
{
    public class EmployeeModel
    {
        [Display(Name ="ID Pracownika")]
        [Required(ErrorMessage ="Muszisz podać id urzytkownika")]
        [Range(100000,999999, ErrorMessage ="Nieprawidłowe ID")]
        public int EmployeeId { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Muszisz podać Imię")]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Muszisz podać Nazwisko")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Muszisz podać Email")]
        public string EmailAddress { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Potwierdź email")]
        [Compare("EmailAddress", ErrorMessage = "Emaile nie są takie same")]
        public string ConfirmEmail { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        [Required(ErrorMessage ="Muszisz podać hasło")]
        [StringLength(100, MinimumLength =10, ErrorMessage ="Musisz wprowadzić hasło o podanych parametrach(10-100)")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło")]
        [Required(ErrorMessage = "Muszisz podać hasło")]
        [Compare("Password", ErrorMessage ="Hasłą nie zgadzają się")]
        public string ConfirmPassword { get; set; }
    }
}