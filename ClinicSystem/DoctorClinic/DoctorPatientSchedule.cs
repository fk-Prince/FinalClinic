using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem.DoctorClinic
{
    public class DoctorPatientSchedule
    {
        private DateTime scheduleDate;
        private TimeSpan startTime;
        private TimeSpan endTime;
        private string operationName;
        private int detailId;
        private TimeSpan duration;
        private string diagnosis;


        public DoctorPatientSchedule(DateTime scheduleDate, TimeSpan startTime, TimeSpan endTime, string operationName, int detailId, TimeSpan duration)
        {
            this.scheduleDate = scheduleDate;
            this.startTime = startTime;
            this.endTime = endTime;
            this.operationName = operationName;
            this.detailId = detailId;
            this.duration = duration;
        }

        public DoctorPatientSchedule(DateTime scheduleDate, TimeSpan startTime, TimeSpan endTime, string operationName, int detailId, TimeSpan duration, string diagnosis)
        {
            this.scheduleDate = scheduleDate;
            this.startTime = startTime;
            this.endTime = endTime;
            this.operationName = operationName;
            this.detailId = detailId;
            this.duration = duration;
            this.diagnosis = diagnosis;
        }

        public DoctorPatientSchedule(DateTime scheduleDate, TimeSpan startTime, TimeSpan endTime)
        {
            this.scheduleDate = scheduleDate;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public TimeSpan Duration { get => duration; }
        public int DetailID { get => detailId; }
        public DateTime ScheduleDate { get => scheduleDate; }
        public TimeSpan StartTime { get => startTime; }
        public TimeSpan EndTime { get => endTime; }
        public string OperationName { get => operationName; }
        public string Diagnosis { get => diagnosis; }
    }
}
