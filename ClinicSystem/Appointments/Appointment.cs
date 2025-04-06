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
        private double bill;
        private int roomno;
        private DateTime dateAdmitted;
        private DateTime recentlyVisit;
        private int appointmentDetailNo;

        private string diagnosis;



        public Appointment( Doctor doctor, DateTime dateSchedule, TimeSpan startTime, TimeSpan endTime, int roomno)
        {
            this.doctor = doctor;
            this.roomno = roomno;
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

        public Appointment(Patient patient, Doctor doctor, Operation operation, DateTime dateSchedule, TimeSpan startTime, TimeSpan endTime, double bill, int roomno,int appointmentDetailId)
        {
            this.patient = patient;
            this.dateSchedule = dateSchedule.Date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.doctor = doctor;
            this.roomno = roomno;
            this.operation = operation;
            this.bill = bill;
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


        public Appointment(Patient patient, Doctor doctor, Operation operation, DateTime dateSchedule, TimeSpan startTime, TimeSpan endTime, int appointmentDetailId, int roomno, DateTime dateAdmitted)
        {
            this.patient = patient;
            this.dateSchedule = dateSchedule.Date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.doctor = doctor;
            this.operation = operation;
            this.appointmentDetailNo = appointmentDetailId;
            this.roomno = roomno;
            this.dateAdmitted = dateAdmitted;
        }

         public Appointment(Patient patient, Doctor doctor, Operation operation, DateTime dateSchedule, TimeSpan startTime, TimeSpan endTime, int appointmentDetailId, int roomno, DateTime dateAdmitted, DateTime recentlyVisit, double bill)
        {
            this.patient = patient;
            this.dateSchedule = dateSchedule.Date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.doctor = doctor;
            this.operation = operation;
            this.appointmentDetailNo = appointmentDetailId;
            this.roomno = roomno;
            this.dateAdmitted = dateAdmitted;
            this.recentlyVisit = recentlyVisit;
            this.bill = bill;
        }


        public Doctor Doctor { get => doctor; }
        public Operation Operation { get => operation; }
        public Patient Patient { get => patient; }
        public DateTime DateSchedule { get => dateSchedule; }
        public DateTime DateVisited { get => dateAdmitted; }
        public DateTime DateRecentlyVisit { get => recentlyVisit; }
        public TimeSpan StartTime { get => startTime;  }
        public TimeSpan EndTime { get => endTime;  }

        public double Bill { get => bill; }
        public int RoomNo { get => roomno; }
        public string Diagnosis { get => diagnosis;  }
        public int AppointmentDetailNo { get => appointmentDetailNo; }
    }
}
