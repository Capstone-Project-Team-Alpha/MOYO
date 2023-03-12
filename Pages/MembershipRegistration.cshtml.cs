using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.OLE.Interop;
using MOYO_Website.Model.Domain;
using MOYO_Website.Technical_Services;

namespace MOYO_Website.Pages
{
    public class MembershipRegistrationModel : PageModel
    {

        //private readonly ICustomerService _customerService;

        //public MembershipRegistrationModel(ICustomerService customerService)
        //{
        //    _customerService = customerService;
        //}
        [BindProperty]
        public string Message { get; set; }
        //brings in attributes of the Customer class
        [BindProperty]
        public Customer newCustomer { get; set; }
        [BindProperty]
        public Login existingUser { get; set; }

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
        public IActionResult OnPost()
        {

           
                try
                {
                    newCustomer.Password = UtilityClass.Encrypt(newCustomer.Email,newCustomer.Password);//encrypty password

                    //validate user does not exist using email
                    existingUser = MOYOHandler.getLoginByUser(newCustomer.Email);
                    if (existingUser == null)
                    {

                        var msg = MOYOHandler.newRegistration(newCustomer);
                        if (string.IsNullOrEmpty(msg))
                        {
                            //return Redirect("/Login");
                            ViewData["msg"] = msg;
                            Message = "Registration Completed Successfully";

                        }
                       

                    }
                    else
                    {
                        ViewData["msg"] = "User already exist";
                    }

                }catch(Exception ex)
                {
                    Message = "Registration Failed";
                }

            
            return Page();
        }
    }
}
