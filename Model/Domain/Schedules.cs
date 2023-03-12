using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MOYO_Website.Model.Domain
{
    public class Schedules
    {
        [BindProperty]
        public int CalendarID { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Appointment Start Time is Required")]
        public string AppointmentStartTime { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Appointment End Time is Required")]
        public string AppointmentEndTime { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Appointment Date is Required")]
        public string AppointmentDate { get; set; }

        [BindProperty]
        public string Message { get; set; }

        [BindProperty]
        public int StaffID { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Appointment Name is Required")]
        public string AppointmentName { get; set; }

        [BindProperty]
        public int MaxParticipants { get; set; }
    }
}
