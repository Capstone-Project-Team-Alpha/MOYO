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
    public class StaffRegistrationModel : PageModel
    {
        public string Message { get; set; }
        //brings in attributes of the Customer class
        public Staff newStaff { get; set; }
        public List<SelectListItem> HProvince { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="", Text="---> Select Home Province<---"},
            new SelectListItem{Value="Alberta", Text="Alberta"},
            new SelectListItem{Value="British Columbia", Text="British Columbia"},
            new SelectListItem{Value="Manitoba", Text="Manitoba"},
            new SelectListItem{Value="Newfoundland and Labrador", Text="Newfoundland and Labrador"},
            new SelectListItem{Value="Nova Scotia", Text="Nova Scotia"},
            new SelectListItem{Value="Ontario", Text="Ontario"},
            new SelectListItem{Value="Prince Edward Island", Text="Prince Edward Island"},
            new SelectListItem{Value="Quebec", Text="Quebec"},
            new SelectListItem{Value="Saskatchewan", Text="Saskatchewan"},
            new SelectListItem{Value="Northwest Territories", Text="Northwest Territories"},
            new SelectListItem{Value="Nunavut", Text="Nunavut"},
            new SelectListItem{Value="Yukon", Text="Yukon"},
        };
        public void OnGet()
        {
        }
    }
}
