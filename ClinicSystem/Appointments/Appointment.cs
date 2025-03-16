using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicSystem.PatientForm;

namespace ClinicSystem
{
    public class Appointment
    {

        private Doctor doctor;
        private DateTime dateSchedule;
        private TimeSpan startTime;
        private TimeSpan endTime;
        private Patient patient;
        private Operation operation;
        private int roomno;
        private string diagnosis;
        private int appointmentDetailNo;


        public Appointment(Operation operation, Doctor doctor, DateTime dateSchedule, TimeSpan startTime, TimeSpan endTime)
        {
            this.doctor = doctor;
            this.operation = operation;
            this.dateSchedule = dateSchedule;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public Appointment(Operation operation, Doctor doctor, DateTime dateSchedule, TimeSpan startTime, TimeSpan endTime, int appointmentDetailId)
        {
            this.doctor = doctor;
            this.operation = operation;
            this.dateSchedule = dateSchedule;
            this.startTime = startTime;
            this.endTime = endTime;
            this.appointmentDetailNo = appointmentDetailId;
        }

        public Appointment( Doctor doctor, DateTime dateSchedule, TimeSpan startTime, TimeSpan endTime)
        {
            this.doctor = doctor;
          
            this.dateSchedule = dateSchedule.Date;
            this.startTime = startTime;
            this.endTime = endTime;
        }
        public Appointment(Patient patient, DateTime dateSchedule, TimeSpan startTime, TimeSpan endTime)
        {
            this.patient = patient;
            this.dateSchedule = dateSchedule.Date;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public Appointment(DateTime dateSchedule, TimeSpan startTime, TimeSpan endTime, Patient patient, Operation operation, int roomno, string diagnosis, int appointmentDetailId)
        {
            this.dateSchedule = dateSchedule;
            this.startTime = startTime;
            this.endTime = endTime;
            this.patient = patient;
            this.operation = operation;
            this.roomno = roomno;
            this.diagnosis = diagnosis;
            appointmentDetailNo = appointmentDetailId;
        }

        public Doctor Doctor { get => doctor; }
        public Operation Operation { get => operation; }
        public Patient Patient { get => patient; }
        public DateTime DateSchedule { get => dateSchedule; }
        public TimeSpan StartTime { get => startTime;  }
        public TimeSpan EndTime { get => endTime;  }

        public int RoomNo { get => roomno; }
        public string Diagnosis { get => diagnosis;  }
        public int AppointmentDetailNo { get => appointmentDetailNo; }
    }
}
