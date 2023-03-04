using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOYO_Website.Model.Domain
{
    public class Customer
    {
        [Required]
        public int CustomerID{ get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string HomeAddress { get; set; }
        public string HomePostalCode { get; set; }
        public string HomePhone { get; set; }
        public string AlternatePhone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string DateOfBirth { get; set; }
        public string HomeCity { get; set; }
        public string HomeProvince { get; set; }
        public string ApplicationStatus { get; set; }
        public string Date { get; set; }

        //Need to add DOB validation to ensure the customer is at least 18 yrs old. 
    }
}
