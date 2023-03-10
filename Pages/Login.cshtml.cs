using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MOYO_Website.Model.Domain;
using MOYO_Website.Technical_Services;

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

        [BindProperty]
        public Login currentLogin { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
           
            currentLogin = LoginService.getlogin(Email, UtilityClass.Encrypt(Email, Password));
           // currentLogin = LoginService.getlogin(Email,  Password);
            if (currentLogin != null)
            {
                HttpContext.Session.SetString("username", currentLogin.email);
                return Redirect("/BookAppointment");

            }

            Message = "Invalid Username or Password";
            return Page();
        }
    }
}
