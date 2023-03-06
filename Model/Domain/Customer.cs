using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOYO_Website.Model.Domain
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Last Name required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "First Name required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Street required")]
        public string Street { get; set; }

        public string Hobbies { get; set; }

        public string Occupation { get; set; }

        //public string HomeAddress { get; set; }

        [Required(ErrorMessage = "Home Postal Code required")]
        public string HomePostalCode { get; set; }
        [Required(ErrorMessage = "Home Phone required")]
        public string HomePhone { get; set; }
        //public string AlternatePhone { get; set; }
        [Required(ErrorMessage = "Email required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Date of Birth required")]
        public string DateOfBirth { get; set; }
        [Required(ErrorMessage = "Home City required")]
        public string HomeCity { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be at least 8 characters", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be at least 8 characters", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        //[Required(ErrorMessage = "Password required")]
        //public string Password { get; set; }
        //[Required(ErrorMessage = "ConfirmPassword required")]
        //public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Home Province required")]
        public string HomeProvince { get; set; }

        public string ApplicationStatus { get; set; }
        //public string Date { get; set; }
        //[Required]
        //public int CustomerID{ get; set; }
        //public string LastName { get; set; }
        //public string FirstName { get; set; }
        //public string HomeAddress { get; set; }
        //public string HomePostalCode { get; set; }
        //public string HomePhone { get; set; }
        //public string AlternatePhone { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }
        //public string ConfirmPassword { get; set; }
        //public string DateOfBirth { get; set; }
        //public string HomeCity { get; set; }
        //public string HomeProvince { get; set; }
        //public string ApplicationStatus { get; set; }
        public string Date { get; set; }

        //Need to add DOB validation to ensure the customer is at least 18 yrs old. 
    }
}
