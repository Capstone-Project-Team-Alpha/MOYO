using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MOYO_Website.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }
        [BindProperty]
        //Email validation goes here
        public string Email { get; set; }
        [BindProperty]
        //First Name validation goes here
        public string FirstName { get; set; }
        [BindProperty]
        //Last Name validation goes here
        public string LastName { get; set; }

        [BindProperty]
        //Question validation goes here
        public string Question { get; set; }
        public void OnGet()
        {
        }
    }
}
