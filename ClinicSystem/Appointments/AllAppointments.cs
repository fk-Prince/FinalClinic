using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicSystem.UserLoginForm;

namespace ClinicSystem.Appointments
{
    public partial class AllAppointments : Form
    {

        private List<Appointment> patientAppointments;
        private ScheduleDatabase db = new ScheduleDatabase();
        public AllAppointments()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            patientAppointments = db.getAppointments();

            List<Appointment> filtered = new List<Appointment>();
            foreach (Appointment pa in patientAppointments)
            {
               
                //if (pa.Schedule.DateSchedule.Date.ToString("yyyy-MM-dd").Equals(today.ToString("yyyy-MM-dd")))
                //{
                //    filtered.Add(pa);
                //}
            }
            displaySchedules(filtered,"TODAY");
           
        }

        private void displaySchedules(List<Appointment> patientAppointments, string comboText)
        {
            flowPanel.Controls.Clear();
            if (patientAppointments.Count > 0)
            {
                foreach (Appointment pa in patientAppointments)
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(300, 310);
                    panel.BackColor = Color.FromArgb(111, 163, 216);
                    panel.Margin = new Padding(15, 10, 10, 10);
                    panel.Padding = new Padding(10, 10, 10, 10);
                    panel.Region = Region.FromHrgn(dll.CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 50, 50));

                    Label label = createLabel("Room No", pa.RoomNo.ToString(), 10, 15);
                    panel.Controls.Add(label);

                    label = createLabel("Operation Code", pa.Operation.OperationCode, 10, 35);
                    panel.Controls.Add(label);

                    label = createLabel("Operation Name", pa.Operation.OperationName, 10, 55);
                    panel.Controls.Add(label);

                    label = createLabel("Schedule", pa.DateSchedule.ToString("yyyy-MM-dd"), 10, 75);
                    panel.Controls.Add(label);

                    DateTime date = DateTime.Today.Add(pa.StartTime);
                    string formattedTime = date.ToString("hh:mm:ss tt");
                    label = createLabel("Start-Time", formattedTime, 10, 95);
                    panel.Controls.Add(label);


                    date = DateTime.Today.Add(pa.EndTime);
                    formattedTime = date.ToString("hh:mm:ss tt");
                    label = createLabel("End-Time", formattedTime, 10, 115);
                    panel.Controls.Add(label);

                    Panel panel2 = new Panel();
                    panel2.BackColor = Color.Gray;
                    panel2.Size = new Size(270, 2);
                    panel2.Location = new Point(15, 155);
                    panel.Controls.Add(panel2);

                    label = createLabel("Patient ID", pa.Patient.Patientid.ToString(), 10, 175);
                    panel.Controls.Add(label);

                    string fullname = pa.Patient.Firstname + " " + pa.Patient.Middlename + " " + pa.Patient.Lastname;
                    label = createLabel("Name", fullname, 10, 190);
                    panel.Controls.Add(label);

                    label = createLabel("Age", pa.Patient.Age.ToString(), 10, 215);
                    panel.Controls.Add(label);

                    label = createLabel("Gender", pa.Patient.Gender, 10, 235);
                    panel.Controls.Add(label);

                    label = createLabel("Contact Number", pa.Patient.ContactNumber, 10, 255);
                    panel.Controls.Add(label);

                    label = createLabel("Date-Admitted", pa.DateAdmitted.ToString("yyyy-MM-dd"), 10, 275);
                    panel.Controls.Add(label);


                    flowPanel.Controls.Add(panel);
                }
            }
            else
            {
                Label label = new Label();
                label.Text = $"CLINIC HAS NO APPOINTMENT {comboText}.";
                label.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                label.AutoSize = true;
                label.Location = new Point(250, 100);
                Panel panel = new Panel();
                panel.Size = new Size(900, 400);
                panel.Controls.Add(label);
                flowPanel.Controls.Add(panel);
            }
        }

        public Label createLabel(string title, string value, int x, int y)
        {
            Label label = new Label();
            label.Text = $"{title}:   {value}";
            label.MaximumSize = new Size(280, 30);
            label.AutoSize = true;
            label.Location = new Point(x, y);
            return label;
        }

        private void radioToday_CheckedChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            List<Appointment> filtered = new List<Appointment>();
            foreach (Appointment pa in patientAppointments)
            {

                if (pa.DateSchedule.Date.ToString("yyyy-MM-dd").Equals(today.ToString("yyyy-MM-dd")))
                {
                    filtered.Add(pa);
                }
            }
            displaySchedules(filtered, "TODAY");
        }

        private void weekRadio_CheckedChanged(object sender, EventArgs e)
        {
            DateTime week = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            List<Appointment> filtered = new List<Appointment>();
            foreach (Appointment pa in patientAppointments)
            {
                if (week <= pa.DateSchedule && pa.DateSchedule < week.AddDays(7))
                {
                    filtered.Add(pa);
                }
            }

            displaySchedules(filtered,"THIS WEEK");
        }

        private void monthRadio_CheckedChanged(object sender, EventArgs e)
        {
            DateTime month = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            DateTime start = new DateTime(month.Year, month.Month, 1);
            DateTime end = start.AddMonths(1).AddDays(-1);

            List<Appointment> filtered = new List<Appointment>();

            foreach (Appointment pa in patientAppointments)
            {
                if (pa.DateSchedule >= start && pa.DateSchedule <= end)
                {
                    filtered.Add(pa);
                }
            }

            displaySchedules(filtered, "THIS MONTH");
        }

        private void allSchedule_CheckedChanged(object sender, EventArgs e)
        {
            DateTime dateNow = DateTime.Now;
            List<Appointment> filtered = new List<Appointment>();

            foreach (Appointment pa in patientAppointments)
            {
                if (pa.DateSchedule >= dateNow)
                {
                    filtered.Add(pa);
                }
            }
            displaySchedules(filtered, "");
        }

        private void selection_CheckedChanged(object sender, EventArgs e)
        {
            if (selection.Checked)
            {
                datePickDate.Visible = true;
            }
            else
            {
                datePickDate.Visible = false;

            }
        }

        private void datePickDate_ValueChanged_1(object sender, EventArgs e)
        {
            pickDate();
        }

        public void pickDate()
        {
            DateTime date = Convert.ToDateTime(datePickDate.Value.ToString("yyyy-MM-dd"));

            List<Appointment> filtered = new List<Appointment>();
            foreach (Appointment pa in patientAppointments)
            {
                if (pa.DateSchedule == date)
                {
                    filtered.Add(pa);
                }
            }
            displaySchedules(filtered, "THIS DATE");
        }
    }
}
