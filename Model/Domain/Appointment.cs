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
    }
}
