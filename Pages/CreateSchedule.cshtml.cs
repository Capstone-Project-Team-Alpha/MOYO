using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MOYO_Website.Pages
{
    public class CreateScheduleModel : PageModel
    {
        public string Message { get; set; }
        public string Message2 { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string IntakeForm { get; set; }
      
        public string LastName { get; set; }
       
        public string FirstName { get; set; }
        public string HomeAddress { get; set; }
        public string HomePostalCode { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }
        public int CustomerID { get; set; }
        public void OnGet()
        {
        }
    }
}
