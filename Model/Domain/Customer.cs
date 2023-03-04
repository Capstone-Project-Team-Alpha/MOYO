using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOYO_Website.Model.Domain
{
    public class Customer
    {
        
        public int CustomerID{ get; set; }

        [Required(ErrorMessage = "Last Name required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "First Name required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Street required")]
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
        [Required(ErrorMessage = "Home Province required")]
        public string HomeProvince { get; set; }
        
        public string ApplicationStatus { get; set; }
        //public string Date { get; set; }
    }
}
