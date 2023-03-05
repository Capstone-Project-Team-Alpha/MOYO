using Microsoft.Data.SqlClient;
using MOYO_Website.Model.Domain;
using System.Data;
using System;
using System.Collections.Generic;
using MOYO_Website.Technical_Services;


namespace MOYO_Website.Technical_Services
{
    public static class LoginService
    {
        private static SqlConnection moyoConnection;



        public static Login getlogin(string email, string pwd)
        {
            moyoConnection = UtilityClass.getmoyoConnectionString();
            Login currentAccess = null;
            try
            {
                SqlParameter useremail = new SqlParameter();
                useremail.ParameterName = "@Email";
                useremail.SqlDbType = SqlDbType.VarChar;
                useremail.Value = email;
                useremail.Direction = ParameterDirection.Input;

                SqlParameter passwd = new SqlParameter();
                passwd.ParameterName = "@password";
                passwd.SqlDbType = SqlDbType.VarChar;
                passwd.Value = pwd;
                passwd.Direction = ParameterDirection.Input;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = moyoConnection;
                cmd.CommandText = "[GetCustomerLogin]";
                cmd.Parameters.Add(useremail);
                cmd.Parameters.Add(passwd);

                if (moyoConnection.State == ConnectionState.Closed)
                { moyoConnection.Open(); }


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.FieldCount != 0)
                        {
                            while (reader.Read())
                            {
                                currentAccess = new Login();
                                currentAccess.email = reader["email"].ToString();
                                currentAccess.password = reader["password"].ToString();
                            }
                        }
                        reader.Close();

                    }

                    moyoConnection.Close();
                }



            }
            catch (Exception ex)
            {
                //ex.Message;
            }

            return currentAccess;
        }

        public static List<Login> getloginbyUsername(string email)
        {
            moyoConnection = UtilityClass.getmoyoConnectionString();
            Login currentAccess = null;
            List<Login> loginList = new List<Login>();

            try
            {
                SqlParameter Emial = new SqlParameter();
                Emial.ParameterName = "@Email";
                Emial.SqlDbType = SqlDbType.NVarChar;
                Emial.Value = email;
                Emial.Direction = ParameterDirection.Input;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = moyoConnection;
                cmd.CommandText = "[GetLoginByUser]";
                cmd.Parameters.Add(Emial);
               
                if (moyoConnection.State == ConnectionState.Closed)
                { moyoConnection.Open(); }


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.FieldCount != 0)
                        {
                            while (reader.Read())
                            {
                                currentAccess = new Login();
                                currentAccess.email = reader["email"].ToString();
                                currentAccess.password = reader["password"].ToString();
                                currentAccess.createDate= Convert.ToDateTime(reader["CreatedDate"].ToString());
                               // currentAccess.status = reader["status"].ToString();

                                loginList.Add(currentAccess);
                            }
                        }
                        reader.Close();

                    }

                    moyoConnection.Close();
                }



            }
            catch (Exception ex)
            {
                //ex.Message;
            }

            return loginList;
        }
    }
}
