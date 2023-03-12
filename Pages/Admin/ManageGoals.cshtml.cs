using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MOYO_Website.Model.Domain;
using MOYO_Website.Technical_Services;
using System.Collections.Generic;

namespace MOYO_Website.Pages.Admin
{
    public class GoalsModel : PageModel
    {
        [BindProperty]
        public string Message { get; set; }
        [BindProperty]
        public List<Goals> dbGoals { get; set; }

        [BindProperty]
        public Goals currentGoals { get; set; }
        [BindProperty]
        public bool isNew { get; set; }
        [BindProperty]
        public bool GoalsListFound { get; set; }
        public IActionResult OnGet()
        {
           getAllGoals();
            return Page();
        }
        private void getAllGoals()
        {
            dbGoals = MOYOHandler.getAllGoals();
            if (dbGoals != null)
            {
                if (dbGoals.Count != 0)
                {
                    GoalsListFound = true;
                }
                else
                {
                    Message = "No Goals found in the system";
                }
            }

        }

        public IActionResult OnPostNewGoal()
        {
            isNew= true;
            getAllGoals();
            return Page();

        }
        public IActionResult OnPostSubmit()
        {
            int confirmation = 0;
            if (ModelState.IsValid)
            {
                confirmation = MOYOHandler.addGoal(currentGoals.Description);
                if (confirmation==1)
                {
                    Message = "New Goal Added";
                    isNew= false;
                }
                else { Message = "Unable to Add New Goal"; }
            }
            getAllGoals();
            return Page();
        }
    }
}
