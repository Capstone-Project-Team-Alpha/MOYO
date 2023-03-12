using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MOYO_Website.Model.Domain;

namespace MOYO_Website.Pages
{

 

namespace MOYO_Website.Pages
    {
        public class CreateScheduleModel : PageModel
        {
            [TempData]
            public string FormResult { get; set; }

            //[BindProperty]
            //public int CalendarID { get; set; }

            [BindProperty]
            [Required(ErrorMessage = "Appointment Start Time is Required")]
            public string AppointmentStartTime { get; set; }

            [BindProperty]
            [Required(ErrorMessage = "Appointment End Time is Required")]
            public string AppointmentEndTime { get; set; }

            [BindProperty]
            [Required(ErrorMessage = "Appointment Date is Required")]
            public string AppointmentDate { get; set; }

            public string Message { get; set; }

            [BindProperty]
            public int StaffID { get; set; }

            //[BindProperty]
            //[Required(ErrorMessage = "Appointment Name is Required")]
            //public string AppointmentName { get; set; }

            [BindProperty]
            public int MaxParticipants { get; set; }

            //[BindProperty]
            //public List<SelectListItem> AppointmentLists { get; set; }

            //[BindProperty]
            //public string Schedules { get; set; }



            //public List<SelectListItem> AppointmentNames { get; } = new List<SelectListItem>
            //{

            //    new SelectListItem{Value="", Text="---> select Appointment Name <---"},
            //    new SelectListItem{Value="001", Text="Guided meditation"},
            //    new SelectListItem{Value="002", Text="Myofascial release"},
            //    new SelectListItem{Value="003", Text="Chakra education"},
            //    new SelectListItem{Value="003", Text="Asana"},
            //    new SelectListItem{Value="003", Text="Mantra"},
            //    new SelectListItem{Value="003", Text="Nidra"},
            //    new SelectListItem{Value="003", Text="Partner yoga"}

            //};

            public void OnGet()
            {

            }

            public void OnPostSubmit()
            {
                /* Temp StaffID to test Stored Procedure */
                StaffID = 1;

                bool Confirmation;
                MOYOHandler RequestMOYO = new MOYOHandler();

                Confirmation = RequestMOYO.CreateSchedule(AppointmentDate, AppointmentStartTime, AppointmentEndTime, StaffID, MaxParticipants);
            }
        }
    }

}

