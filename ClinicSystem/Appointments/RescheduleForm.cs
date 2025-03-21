﻿using System;
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
        private List<Appointment> appointments = new List<Appointment>();
        private ScheduleDatabase db = new ScheduleDatabase();
        private Appointment selectedAppointment;
        public RescheduleForm(Staff staff)
        {
            InitializeComponent();
            List<Appointment> filter = db.getAppointments();
            updateAppointmentB.Region = Region.FromHrgn(dll.CreateRoundRectRgn(0, 0, updateAppointmentB.Width, updateAppointmentB.Height, 20, 20));
            DateTime currentDate = DateTime.Now;
            foreach (Appointment f in filter)
            {  
                DateTime appointmentDateTime = f.DateSchedule.Date.Add(f.StartTime);

                if (appointmentDateTime > currentDate)
                {
                    appointments.Add(f);
                }
            }

            foreach (Appointment appointment in appointments)
            {
                comboAppointment.Items.Add(appointment.AppointmentDetailNo);
            }
        }



        private void comboAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAppointment.SelectedIndex == -1) return;
            int comboA = int.Parse(comboAppointment.SelectedItem.ToString());
            foreach (Appointment selected in appointments)
            {
                if (selected.AppointmentDetailNo == comboA)
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
                tbOname.Text = selectedAppointment.Operation.OperationName;
                dateSchedulePicker.Value = selectedAppointment.DateSchedule;

                string dfullname = $"{selectedAppointment.Doctor.DoctorFirstName} " +
                                   $"{selectedAppointment.Doctor.DoctorFirstName}  " +
                                   $"{selectedAppointment.Doctor.DoctorFirstName}";
                doctorL.Text = dfullname;

                DateTime date = selectedAppointment.DateSchedule;
                DateTime startDateTime = date.Add(selectedAppointment.StartTime);
                string formatStart;
                formatStart = startDateTime.ToString("hh:mm:ss tt");
                string[] ampmStart = formatStart.Split(' ');
                tbStart.Text = ampmStart[0];
                comboStart.SelectedItem = ampmStart[1];


                DateTime datey = date.Add(selectedAppointment.EndTime); 
                if (datey.Hour >= 0 && datey.Hour < 12)
                {  
                    tbEnd.Text = datey.ToString("HH:mm:ss tt").Split(' ')[0]; 
                    comboEnd.SelectedItem = "AM";  
                }
                else
                {
                    string formattedEndTime = datey.ToString("hh:mm:ss tt");
                    tbEnd.Text = formattedEndTime.Split(' ')[0];  
                    comboEnd.SelectedItem = "PM";  
                }

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

            if (selectedAppointment.DateSchedule == dateSchedulePicker.Value && selectedAppointment.StartTime == origStartTime && selectedAppointment.EndTime == origEndTime)
            {
                return;
            }

            Appointment app = new Appointment(selectedAppointment.Operation,
                selectedAppointment.Doctor,
                dateSchedulePicker.Value,
                origStartTime,
                origEndTime,
                selectedAppointment.AppointmentDetailNo);

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
                TimeSpan endTime = startTimeSpan + selectedAppointment.Operation.Duration;
                if (endTime.TotalHours >= 24)
                {
                    endTime = TimeSpan.FromHours(endTime.TotalHours % 24);
                }
                DateTime endDateTime = DateTime.Today.Add(endTime);
                origEndTime = TimeSpan.Parse(endDateTime.ToString("HH:mm:ss"));
                if (endDateTime.Hour >= 0 && endDateTime.Hour < 12)
                {
                    tbEnd.Text = endDateTime.ToString("HH:mm:ss tt").Split(' ')[0];
                    comboEnd.SelectedItem = "AM";
                }
                else
                {
                    string formattedEndTime = endDateTime.ToString("hh:mm:ss tt");
                    tbEnd.Text = formattedEndTime.Split(' ')[0];
                    comboEnd.SelectedItem = "PM";
                }
            }
        }

        private void comboStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            scheduleChanged();
        }
    }
}
