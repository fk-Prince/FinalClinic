using System;

using ClinicSystem.PatientForm;

namespace ClinicSystem.Appointments
{
    public class DoctorOperation
    {
        private Doctor doctor;
        private Operation operation;
        private Appointment schedule;
        private int roomno;
        private Patient patient;
        private DateTime dateAdmitted;
        public DoctorOperation(Doctor doctor, Operation operation, Appointment schedule)
        {
            this.doctor = doctor;
            this.operation = operation;
            this.schedule = schedule;
        }

        public DoctorOperation(Appointment schedule, int roomno, Patient patient, DateTime dateAdmitted)
        {
            this.schedule = schedule;
            this.roomno = roomno;
            this.patient = patient;
            this.dateAdmitted = dateAdmitted;
        }

        public Doctor Doctor { get => doctor;  }
        public Operation Operation { get => operation; }
        public Appointment Schedule { get => schedule; }
        public int Roomno { get => roomno;  }
        public Patient Patient { get => patient; }
        public DateTime DateAdmitted { get => dateAdmitted; }
    }
}
