using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MOYO_Website.Pages
{
    public class AboutMeModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
        }
    }
}
