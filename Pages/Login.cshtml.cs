using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MOYO_Website.Pages
{
    public class LoginModel : PageModel
    {
        public string Message { get; set; }
        [BindProperty]
        //Email validation goes here
        public string Email { get; set; }
        [BindProperty]
        //Password validation goes here
        public string Password { get; set; }
        public void OnGet()
        {
        }
    }
}
