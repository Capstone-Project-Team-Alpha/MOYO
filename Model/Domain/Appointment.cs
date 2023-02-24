using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOYO_Website.Model.Domain
{
    public class Appointment
    {
        [Required]
        public string Date { get; set; }

        [Required]
        public string Time { get; set; }

        public int CalendarID { get; set; }
        public int CustomerID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public bool WaiverSigned { get; set; }
        public string Witness { get; set; }
        public int CalenderID { get; set; }

        public string Status { get; set; }




    }
}
