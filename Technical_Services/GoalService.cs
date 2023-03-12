using Microsoft.Data.SqlClient;
using MOYO_Website.Model.Domain;
using System.Collections.Generic;
using System.Data;
using System;

namespace MOYO_Website.Technical_Services
{
    public static class GoalService
    {

        private static SqlConnection moyoConnection;

        public static List<Goals> getAllGoals()
        {
            moyoConnection = UtilityClass.getmoyoConnectionString();
            Goals currentGoals = null;
            List<Goals> GoalsList = new List<Goals>();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = moyoConnection;
                cmd.CommandText = "[GetAllGoals]";

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
                                currentGoals = new Goals();
                                currentGoals.GoalId = int.Parse(reader["GoalsID"].ToString());
                                currentGoals.Description = reader["GoalDescription"].ToString();
                                currentGoals.CreatedDate = Convert.ToDateTime(reader["CreatedDate"].ToString()).ToShortDateString();
                                currentGoals.LastModifiedDate = Convert.ToDateTime(reader["CreatedDate"].ToString()).ToShortDateString();

                                GoalsList.Add(currentGoals);
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
            finally
            {
                if (ConnectionState.Closed != moyoConnection.State) { moyoConnection.Close(); }
            }

            return GoalsList;
        }

        public static int newGoals(string desc)
        {
            moyoConnection = UtilityClass.getmoyoConnectionString();
            int i = 0;
            try
            {
                SqlParameter description = new SqlParameter();
                description.ParameterName = "@Description";
                description.SqlDbType = SqlDbType.VarChar;
                description.Value = desc;
                description.Direction = ParameterDirection.Input;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = moyoConnection;
                cmd.CommandText = "[createGoals]";
                cmd.Parameters.Add(description);


                if (moyoConnection.State == ConnectionState.Closed)
                {
                    moyoConnection.Open();

                    cmd.ExecuteNonQuery();
                    i = 1;
                }

            }
            catch (Exception ex)
            {
                i = 0;
            }
            finally
            {
                if (ConnectionState.Closed != moyoConnection.State) { moyoConnection.Close(); }
            }

            return i;
        }
        //public static List<Goals> getAllGoalsbyId(int id)
        //{
        //    moyoConnection = UtilityClass.getmoyoConnectionString();
        //    Login currentAccess = null;
        //    List<Goals> GoalsList = new List<Goals>();

        //    try
        //    {
        //        SqlParameter Id = new SqlParameter();
        //        Id.ParameterName = "@Email";
        //        Id.SqlDbType = SqlDbType.NVarChar;
        //        Id.Value = Id;
        //        Id.Direction = ParameterDirection.Input;

        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Connection = moyoConnection;
        //        cmd.CommandText = "[GetLoginByUser]";
        //        cmd.Parameters.Add(Emial);

        //        if (moyoConnection.State == ConnectionState.Closed)
        //        { moyoConnection.Open(); }


        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            if (reader.HasRows)
        //            {
        //                if (reader.FieldCount != 0)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        currentAccess = new Login();
        //                        currentAccess.email = reader["email"].ToString();
        //                        currentAccess.password = reader["password"].ToString();
        //                        currentAccess.createDate = Convert.ToDateTime(reader["CreatedDate"].ToString());
        //                        // currentAccess.status = reader["status"].ToString();

        //                        loginList.Add(currentAccess);
        //                    }
        //                }
        //                reader.Close();

        //            }

        //            moyoConnection.Close();
        //        }



        //    }
        //    catch (Exception ex)
        //    {
        //        //ex.Message;
        //    }

        //    return loginList;
        //}
    }
}
