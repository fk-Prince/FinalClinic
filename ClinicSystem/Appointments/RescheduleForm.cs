using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicSystem.UserLoginForm;

namespace ClinicSystem.Appointments
{
    public partial class RescheduleForm : Form
    {
        private List<DoctorOperation> appointments = new List<DoctorOperation>();
        private ScheduleDatabase db = new ScheduleDatabase();
        private DoctorOperation selectedAppointment;
        public RescheduleForm(Staff staff)
        {
            InitializeComponent();
            List< DoctorOperation> filter = db.getAppointments();

            DateTime currentDate = DateTime.Now;
            foreach (DoctorOperation f in filter)
            {  
                DateTime appointmentDateTime = f.Schedule.DateSchedule.Date.Add(f.Schedule.StartTime);

                if (appointmentDateTime > currentDate)
                {
                    appointments.Add(f);
                }
            }

            foreach (DoctorOperation appointment in appointments)
            {
                comboAppointment.Items.Add(appointment.Schedule.AppointmentDetailNo);
            }
        }



        private void comboAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAppointment.SelectedIndex == -1) return;
            int comboA = int.Parse(comboAppointment.SelectedItem.ToString());
            foreach (DoctorOperation selected in appointments)
            {
                if (selected.Schedule.AppointmentDetailNo == comboA)
                {
                    selectedAppointment = selected;
                }
            }
            if (selectedAppointment != null)
            {
                string fullname = $"{selectedAppointment.Patient.Firstname}  " +
                                  $"{selectedAppointment.Patient.Middlename}  " +
                                  $"{selectedAppointment.Patient.Lastname}";
                tbPname.Text = fullname;
                tbOname.Text = selectedAppointment.Schedule.Operation.OperationName;
                dateSchedulePicker.Value = selectedAppointment.Schedule.DateSchedule;

                string dfullname = $"{selectedAppointment.Schedule.Doctor.DoctorFirstName} " +
                                   $"{selectedAppointment.Schedule.Doctor.DoctorFirstName}  " +
                                   $"{selectedAppointment.Schedule.Doctor.DoctorFirstName}";
                doctorL.Text = dfullname;

                DateTime date = selectedAppointment.Schedule.DateSchedule;
                DateTime startDateTime = date.Add(selectedAppointment.Schedule.StartTime);
                string formatStart = startDateTime.ToString("hh:mm:ss tt");
                string[] ampmStart = formatStart.Split(' ');
                tbStart.Text = ampmStart[0];
                comboStart.SelectedItem = ampmStart[1];

             
                DateTime endDateTime = date.Add(selectedAppointment.Schedule.EndTime);
                string formatEnd = endDateTime.ToString("hh:mm:ss tt");
                string[] ampmEnd = formatEnd.Split(' ');
                tbEnd.Text = ampmEnd[0];
                comboEnd.SelectedItem = ampmEnd[1];
            }
        }

        private void updateAppointmentB_Click(object sender, EventArgs e)
        {
            if (comboAppointment.SelectedIndex == -1)
            {
                MessageBox.Show("No Appointment Selected.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TimeSpan startTime;
            if (!TimeSpan.TryParseExact(tbStart.Text.ToString(), @"hh\:mm\:ss", null, out startTime))
            {
                MessageBox.Show("Invalid time, Please enter valid time(hh:mm:ss).", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(tbStart.Text.Split(':')[0]) >= 12)
            {
                MessageBox.Show("Enter 12 hours format (00:00:00) - (11:59:00).", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(tbStart.Text.Split(':')[1]) >= 60 || int.Parse(tbStart.Text.Split(':')[2]) >= 60)
            {
                MessageBox.Show("Minutes and seconds must be between 00 and 59.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (origStartTime == null || origEndTime == null) return;

            if (selectedAppointment.Schedule.DateSchedule == dateSchedulePicker.Value && selectedAppointment.Schedule.StartTime == origStartTime && selectedAppointment.Schedule.EndTime == origEndTime)
            {
                return;
            }

            Appointment app = new Appointment(selectedAppointment.Schedule.Operation,
                selectedAppointment.Schedule.Doctor,
                dateSchedulePicker.Value,
                origStartTime,
                origEndTime,
                selectedAppointment.Schedule.AppointmentDetailNo);

            bool available = db.isAvailable(app);
            if (available)
            {
                bool updated = db.UpdateSchedule(app);
                if (updated)
                {
                    MessageBox.Show("Appointment is updated.", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("This schdule conflict other schedule.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbStart_TextChanged(object sender, EventArgs e)
        {
            scheduleChanged();
        }

        private TimeSpan origStartTime;
        private TimeSpan origEndTime;
        public void scheduleChanged()
        {
            DateTime startTime;
            if (comboStart.SelectedIndex == -1) return;
            string ampm = comboStart.SelectedItem.ToString();
            string timeInput = tbStart.Text + " " + ampm;
            if (DateTime.TryParseExact(timeInput, @"hh\:mm\:ss tt", null, DateTimeStyles.None, out startTime))
            {    
                TimeSpan startTimeSpan = startTime.TimeOfDay;
                origStartTime = startTimeSpan;
                TimeSpan endTime = startTimeSpan + selectedAppointment.Schedule.Operation.Duration;
                if (endTime.TotalHours >= 24)
                {
                    origEndTime = endTime;
                    endTime = TimeSpan.FromHours(endTime.TotalHours % 24);
                }
                DateTime endDateTime = DateTime.Today.Add(endTime);
                string formattedEndTime = endDateTime.ToString(@"hh\:mm\:ss tt");
                tbEnd.Text = formattedEndTime.Split(' ')[0];
                string ampmEnd = endTime.Hours >= 12 ? "PM" : "AM";
                comboEnd.SelectedItem = ampmEnd;
            }
        }

        private void comboStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            scheduleChanged();
        }
    }
}
