using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MOYO_Website.Model.Domain;

namespace MOYO_Website.Pages
{
    public class BookAppointmentModel : PageModel
    {
        public string Message { get; set; }
        public string Message2 { get; set; }
        public int BookingID { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string IntakeForm { get; set; }
        public int CustomerID { get; set; }
        public string Offerings { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string HomeAddress { get; set; }
        public string HomePostalCode { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }
        public int WaiverSigned { get; set; }
        public string Witness { get; set; }
        public int CalenderID { get; set; }
        public string Asna { get; set; }
        public string Status { get; set; }
        [BindProperty]
        public List<SelectListItem> OfferingLists { get; set; }
        public List<SelectListItem> AsnaLists { get; set; }
        public Appointment AvailableAppointment { get; set; }
        public Customer newCustomer { get; set; }
        public void OnGet()
        {
        }
    }
}
