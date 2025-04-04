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
using ClinicSystem.Rooms;
using ClinicSystem.UserLoginForm;

namespace ClinicSystem.Appointments
{
    public partial class RescheduleForm : Form
    {
        private List<Appointment> appointments = new List<Appointment>();
        private AppointmentDatabase db = new AppointmentDatabase();
        private Appointment selectedAppointment;
        private List<Room> rooms = new List<Room>();
        public RescheduleForm(Staff staff)
        {
            InitializeComponent();
            List<Appointment> filter = db.getAppointments();
            rooms = db.getRoomNo();
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

                int index = 0;
                foreach (Room room in rooms)
                {
                    if (room.RoomNo == selectedAppointment.RoomNo || room.Roomtype.Equals("General", StringComparison.OrdinalIgnoreCase))
                    {
                        comboRoom.Items.Add(selectedAppointment.RoomNo + " | " + room.Roomtype);
                        comboRoom.SelectedIndex = index;
                        continue;
                    }
                    if (selectedAppointment.Operation.OperationName.Contains(room.Roomtype))
                    {
                        comboRoom.Items.Add(room.RoomNo + " | " + room.Roomtype);
                        index++;
                    }
                   
                }

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
                MessagePromp.MainShowMessage(this, "No Appointment Selected.", MessageBoxIcon.Error);
                return;
            }

            
            TimeSpan startTime;
            if (!TimeSpan.TryParseExact(tbStart.Text.ToString(), @"hh\:mm\:ss", null, out startTime))
            {
                MessagePromp.MainShowMessageBig(this, "Invalid time, Please enter valid time(hh:mm:ss).", MessageBoxIcon.Error);
                return;
            }

            DateTime selectedDate = this.dateSchedulePicker.Value.Date;
            DateTime currentDateTime = DateTime.Now;
            DateTime selectedStartDateTime = selectedDate.Add(startTime);
            if (selectedStartDateTime < currentDateTime)
            {
                MessagePromp.MainShowMessage(this, "Time is already past.", MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(tbStart.Text.Split(':')[0]) >= 12)
            {
                MessagePromp.MainShowMessageBig(this, "Enter 12 hours format (00:00:00) - (11:59:00).", MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(tbStart.Text.Split(':')[1]) >= 60 || int.Parse(tbStart.Text.Split(':')[2]) >= 60)
            {
                MessagePromp.MainShowMessageBig(this, "Minutes and seconds must be between 00 and 59.", MessageBoxIcon.Error);
                return;
            }

            if (origStartTime == null || origEndTime == null) return;

            if (selectedAppointment.DateSchedule == dateSchedulePicker.Value && selectedAppointment.StartTime == origStartTime && selectedAppointment.EndTime == origEndTime)
            {
                return;
            }
            int roomno = int.Parse(comboRoom.SelectedItem.ToString().Split(' ')[0].Trim());
            

            Appointment app = new Appointment(selectedAppointment.Operation,
                selectedAppointment.Doctor,
                dateSchedulePicker.Value,
                origStartTime,
                origEndTime,
                selectedAppointment.AppointmentDetailNo);

            bool available = db.isReAppointmentAvailable(app);
            if (available)
            {
                bool isRoomAvailable = db.isRoomAvailable(roomno, selectedDate, origStartTime, origEndTime, int.Parse(comboAppointment.SelectedItem.ToString()));
                if (!isRoomAvailable)
                {
                    MessagePromp.MainShowMessageBig(this, "Room is not available during this time.", MessageBoxIcon.Error);
                    return;
                }
                bool updated = db.UpdateSchedule(app);
                if (updated)
                {
                    MessagePromp.MainShowMessage(this, "Appointment is updated.", MessageBoxIcon.Information);
                }
            }
            else
            {
                MessagePromp.MainShowMessageBig(this, "This schdule conflict other schedule.", MessageBoxIcon.Error);
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
