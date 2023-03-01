using Microsoft.Data.SqlClient;
using MOYO_Website.Model.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MOYO_Website.Technical_Services
{

   public interface ICustomerService
    {
        void AddNewCustomer(Customer customer);
    }
    public class CustomerService : ICustomerService
    {
        private static SqlConnection moyoConnection;
        public void AddNewCustomer(Customer customer)
        {
            moyoConnection = UtilityClass.getmoyoConnectionString();

            try
            {
                SqlParameter firstname = new SqlParameter();
                firstname.ParameterName = "@FirstName";
                firstname.SqlDbType = SqlDbType.VarChar;
                firstname.Value = customer.FirstName;
                firstname.Direction = ParameterDirection.Input;

                SqlParameter LastName = new SqlParameter();
                LastName.ParameterName = "@LastName";
                LastName.SqlDbType = SqlDbType.VarChar;
                LastName.Value = customer.LastName;
                LastName.Direction = ParameterDirection.Input;

                SqlParameter Street = new SqlParameter();
                Street.ParameterName = "@Street";
                Street.SqlDbType = SqlDbType.VarChar;
                Street.Value = customer.Street;
                Street.Direction = ParameterDirection.Input;


                SqlParameter City = new SqlParameter();
                City.ParameterName = "@City";
                City.SqlDbType = SqlDbType.VarChar;
                City.Value = customer.HomeCity;
                City.Direction = ParameterDirection.Input;


                SqlParameter Province = new SqlParameter();
                Province.ParameterName = "@Province";
                Province.SqlDbType = SqlDbType.VarChar;
                Province.Value = customer.HomeProvince;
                Province.Direction = ParameterDirection.Input;


                SqlParameter PostalCode = new SqlParameter();
                PostalCode.ParameterName = "@PostalCode";
                PostalCode.SqlDbType = SqlDbType.VarChar;
                PostalCode.Value = customer.HomePostalCode;
                PostalCode.Direction = ParameterDirection.Input;


                SqlParameter DateOfBirth = new SqlParameter();
                DateOfBirth.ParameterName = "@DateOfBirth";
                DateOfBirth.SqlDbType = SqlDbType.DateTime;
                DateOfBirth.Value = customer.DateOfBirth;
                DateOfBirth.Direction = ParameterDirection.Input;

                SqlParameter Phone_Number = new SqlParameter();
                Phone_Number.ParameterName = "@Phone_Number";
                Phone_Number.SqlDbType = SqlDbType.VarChar;
                Phone_Number.Value = customer.HomePhone;
                Phone_Number.Direction = ParameterDirection.Input;

                SqlParameter Email = new SqlParameter();
                Email.ParameterName = "@Email";
                Email.SqlDbType = SqlDbType.VarChar;
                Email.Value = customer.Email;
                Email.Direction = ParameterDirection.Input;


                SqlParameter Hobbies = new SqlParameter();
                Hobbies.ParameterName = "@Hobbies";
                Hobbies.SqlDbType = SqlDbType.VarChar;
                Hobbies.Value = customer.Hobbies;
                Hobbies.Direction = ParameterDirection.Input;

                SqlParameter Occupation = new SqlParameter();
                Occupation.ParameterName = "@Occupation";
                Occupation.SqlDbType = SqlDbType.VarChar;
                Occupation.Value = customer.Occupation;
                Occupation.Direction = ParameterDirection.Input;


                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = moyoConnection;
                cmd.CommandText = "[CreateMembershipRegistration]";
                cmd.Parameters.Add(firstname);
                cmd.Parameters.Add(LastName);
                cmd.Parameters.Add(Phone_Number);
                cmd.Parameters.Add(Hobbies);
                cmd.Parameters.Add(Street);
                cmd.Parameters.Add(City);
                cmd.Parameters.Add(Email);
                cmd.Parameters.Add(PostalCode);
                cmd.Parameters.Add(DateOfBirth);
                cmd.Parameters.Add(Province);
                cmd.Parameters.Add(Occupation);

                if (moyoConnection.State == ConnectionState.Closed)
                {
                    moyoConnection.Open();
                    cmd.ExecuteNonQuery();
                    moyoConnection.Close();
                }
            }
            catch(Exception ex)
            {

            }
       }
    }
}
