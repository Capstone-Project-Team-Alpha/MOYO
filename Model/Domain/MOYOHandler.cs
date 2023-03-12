using MOYO_Website.Technical_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOYO_Website.Model.Domain;

namespace MOYO_Website.Model.Domain
{
    public static class MOYOHandler
    {
        public static Login Login(string username, string password)
        {
            Login currentLogin = new Login();
          
            try
            {
                currentLogin = LoginService.getlogin(username, password);

            }
            catch (Exception ex)
            {
                return currentLogin;
            }
            return currentLogin;
        }

        public static Login getLoginByUser(string username)
        {
            Login currentLogin = new Login();

            try
            {
                currentLogin = LoginService.getloginbyUsername(username);

            }
            catch (Exception ex)
            {
                return currentLogin;
            }
            return currentLogin;
        }
        public static int addGoal(string description)
        {
           int i=0;

            try
            {
                i = GoalService.newGoals(description);

            }
            catch (Exception ex)
            {
                return i;
            }
            return i;
        }

        public static string newRegistration(Customer newCustomer)
        {
            string i = "";

            try
            {
                i = RegistrationService.CreateApplication(newCustomer);

            }
            catch (Exception ex)
            {
                return i;
            }
            return i;
        }

        public static List<Goals> getAllGoals()
        {
           List<Goals> goalsList=new List<Goals>();

            try
            {
                goalsList = GoalService.getAllGoals();

            }
            catch (Exception ex)
            {
                return goalsList;
            }
            return goalsList;
        }
    }
}
