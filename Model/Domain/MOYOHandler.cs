using MOYO_Website.Technical_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOYO_Website.Model.Domain
{
    public class MOYOHandler
    {
        #region Schedule

        public bool CreateSchedule(string AppointmentDate, string AppointmentStartTime, string AppointmentEndTime, int StaffID, int MaxParticipants)
        {
            bool Confirmation = false;

            Schedule ScheduleRequest = new Schedule();
            Confirmation = ScheduleRequest.AddSchedule(AppointmentDate, AppointmentStartTime, AppointmentEndTime, StaffID, MaxParticipants);

            return Confirmation;
        }

        #endregion
    }
}
