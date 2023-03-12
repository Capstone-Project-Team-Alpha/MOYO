using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using MOYO_Website.Model.Domain;

namespace MOYO_Website.Technical_Services
{
    public class Schedule
    {
        private static SqlConnection moyoConnection;

        public bool AddSchedule(string AppointmentDate, string AppointmentStartTime, string AppointmentEndTime, int StaffID, int MaxParticipants)
        {
            bool Confirmation = false;

            moyoConnection = UtilityClass.getmoyoConnectionString();

            #region Create Schedule Code
            SqlCommand CreateScheduleRequest = new SqlCommand();
            CreateScheduleRequest.CommandType = CommandType.StoredProcedure;
            CreateScheduleRequest.Connection = moyoConnection;
            CreateScheduleRequest.CommandText = "CreateSchedule";

            SqlParameter aParameter;

            //aParameter = new SqlParameter();
            //aParameter.ParameterName = "@AppointmentName";
            //aParameter.SqlDbType = SqlDbType.Char;
            //aParameter.Direction = ParameterDirection.Input;
            //aParameter.SqlValue = AppointmentName;

            //CreateScheduleRequest.Parameters.Add(aParameter);

            aParameter = new SqlParameter();
            aParameter.ParameterName = "@AppointmentDate";
            aParameter.SqlDbType = SqlDbType.Date;
            aParameter.Direction = ParameterDirection.Input;
            aParameter.SqlValue = AppointmentDate;

            CreateScheduleRequest.Parameters.Add(aParameter);

            aParameter = new SqlParameter();
            aParameter.ParameterName = "@AppointmentStartTime";
            aParameter.SqlDbType = SqlDbType.Time;
            aParameter.Direction = ParameterDirection.Input;
            aParameter.SqlValue = AppointmentStartTime;

            CreateScheduleRequest.Parameters.Add(aParameter);

            aParameter = new SqlParameter();
            aParameter.ParameterName = "@AppointmentEndTime";
            aParameter.SqlDbType = SqlDbType.Time;
            aParameter.Direction = ParameterDirection.Input;
            aParameter.SqlValue = AppointmentEndTime;

            CreateScheduleRequest.Parameters.Add(aParameter);

            aParameter = new SqlParameter();
            aParameter.ParameterName = "@StaffID";
            aParameter.SqlDbType = SqlDbType.Int;
            aParameter.Direction = ParameterDirection.Input;
            aParameter.SqlValue = StaffID;

            CreateScheduleRequest.Parameters.Add(aParameter);

            aParameter = new SqlParameter();
            aParameter.ParameterName = "@MaxParticipants";
            aParameter.SqlDbType = SqlDbType.Int;
            aParameter.Direction = ParameterDirection.Input;
            aParameter.SqlValue = MaxParticipants;

            CreateScheduleRequest.Parameters.Add(aParameter);

            moyoConnection.Open();

            try
            {
                CreateScheduleRequest.ExecuteNonQuery();

                Confirmation = true;
            }
            catch (Exception ex)
            {

            }

            moyoConnection.Close();
            #endregion

            return Confirmation;
        }
    }
}
