using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicSystem.DoctorClinic;
using ClinicSystem.PatientForm;

namespace ClinicSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginUserForm());
           
            //Patient p = new Patient(1, "prince", "iba", "sestoso", "roxas", 21, "male", DateTime.Now, "09771171913");
            //Doctor d = new Doctor(1, "John Doe", "xc", "Laasssd", 21, "0977", DateTime.Now, "Male", "roxasasdbas","09771171913");
            //Operation x = new Operation("GE44", "Surgery", DateTime.Now, "dfgdbgdfgndf", 5000, TimeSpan.Parse("05:00:00"), "operation room");
            //Appointment ap = new Appointment(p, d, x, DateTime.Now, TimeSpan.Parse("05:00:00"), TimeSpan.Parse("05:00:00"), 6000, 402, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.\r\n");
            //List<Appointment> app = new List<Appointment>();
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap); 
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //app.Add(ap);
            //PrintAppointmentReceipt prrr = new PrintAppointmentReceipt(ap.Patient,app,"Add");
            //prrr.print();
            //Application.Run(prrr);
        }
    }
}
