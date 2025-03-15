using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ClinicSystem.DoctorClinic;
using DoctorClinic;

namespace ClinicSystem
{
    public partial class DoctorViewPatient : Form
    {
        private List<Appointment> patientAppointments;

        private DoctorPatientSchedule schedules;
        private DoctorDatabase db = new DoctorDatabase();
        private DataGridViewRow lastSelectedRow = null;
        private DataTable dt;
        private Doctor dr;

    

        private int limitCharacter = 200;
        private int detailId;
        private TimeSpan duration;
        public DoctorViewPatient(Doctor dr)
        {
            this.dr = dr;
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("RoomNo", typeof(string));
            dt.Columns.Add("PatientID", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("MiddleName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            dt.Columns.Add("Birth-Date", typeof(DateTime));
            patientAppointments = db.getPatients(dr.DoctorID);
            addRows(patientAppointments);

            patientGrid.DataSource = dt;
            patientGrid.Columns["Birth-Date"].DefaultCellStyle.Format = "yyyy-MM-dd";

            datePickerSchedule.Value = DateTimePicker.MinimumDateTime;
            datePickerBDay.Value = DateTimePicker.MinimumDateTime;
        }

        private void addRows(List<Appointment> patientAppointments)
        {
            dt.Clear();
            foreach (Appointment pa in patientAppointments)
            {
                bool duplicate = false;
                foreach (DataRow row in dt.Rows)
                {
                    if (Convert.ToInt32(row["PatientID"]) == pa.Patient.Patientid)
                    {
                        duplicate = true;
                        break;
                    }
                }
                if (!duplicate)
                {
                    dt.Rows.Add(
                        pa.RoomNo,
                        pa.Patient.Patientid,
                        pa.Patient.Firstname,
                        pa.Patient.Middlename,
                        pa.Patient.Lastname,
                        pa.Patient.Gender,
                        pa.Patient.Age,
                        Convert.ToDateTime(pa.Patient.Birthdate.ToString("yyyy-MM-dd"))
                    );
                }
            }
        }

        private void patientClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = patientGrid.Rows[e.RowIndex];

                int patientID = Convert.ToInt32(row.Cells["PatientID"].Value);
                Appointment selectedPatient = null;
                foreach (Appointment pa in patientAppointments)
                {
                    if (pa.Patient.Patientid == patientID)
                    {
                        selectedPatient = pa;
                        break;
                    }
                }
                if (lastSelectedRow != null)
                {
                    lastSelectedRow.DefaultCellStyle.BackColor = Color.White;
                    lastSelectedRow.DefaultCellStyle.ForeColor = Color.Black;
                }

                row.DefaultCellStyle.ForeColor = Color.White;
                row.DefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
                lastSelectedRow = row;

                if (selectedPatient != null)
                {
                    tabControl.SelectedIndex = 1;
                    clear();
                    patientDetails(selectedPatient);
                }
            }
        }

        private void clear()
        {
            comboOperations.Items.Clear();
            tbPatientId.Text = "";
            RoomNo.Text = "";
            tbFullName.Text = "";
            tbAddress.Text = "";
            tbAge.Text = "";
            tbGender.Text = "";
            tbContact.Text = "";
            datePickerSchedule.Value = DateTimePicker.MinimumDateTime;
            datePickerBDay.Value = DateTimePicker.MinimumDateTime;
            tbStartTime.Text = "";
            tbEndTime.Text = "";
        }

        private void patientDetails(Appointment pa)
        {
            tbPatientId.Text = pa.Patient.Patientid.ToString();
            RoomNo.Text = pa.RoomNo.ToString();
            tbFullName.Text =
                pa.Patient.Firstname + "  " + pa.Patient.Middlename + "  " + pa.Patient.Lastname;
            tbAddress.Text = pa.Patient.Address;
            tbAge.Text = pa.Patient.Age.ToString();
            tbGender.Text = pa.Patient.Gender;
            tbContact.Text = pa.Patient.ContactNumber;
            datePickerBDay.Value = pa.Patient.Birthdate;
            foreach (Appointment pas in patientAppointments)
            {
                if (pa.Patient.Patientid == pas.Patient.Patientid)
                {
                    filtered.Add(pas);
                    comboOperations.Items.Add(pas.Operation.OperationName);
                }
            }
        }
        private List<Appointment> filtered = new List<Appointment>();
        private Appointment selectedAppointment;

        private void comboOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboOperations.SelectedIndex == -1)
            {
                tbStartTime.Text = "";
                tbEndTime.Text = "";
                detailId = 0;
                return;
            }
            string operationName = comboOperations.SelectedItem.ToString();
            foreach (Appointment app in filtered)
            {
                if (app.Operation.OperationName.Equals(operationName))
                {
   
                    datePickerSchedule.Value = app.DateSchedule;
                    duration = app.Operation.Duration;
                    detailId = app.AppointmentDetailNo;
                    tbDiagnosis.Text = app.Diagnosis;
                    TimeSpan startTime = app.StartTime;
                    if (startTime.TotalHours >= 24)
                    {
                        startTime = TimeSpan.FromHours(startTime.TotalHours % 24);
                        origStartTime = startTime;
                    }
                    DateTime starTimeD = DateTime.Today.Add(startTime);
                    string ampmStart = startTime.Hours >= 12 ? "PM" : "AM";
                    comboStart.SelectedItem = ampmStart;
                    string formattedStartTime = starTimeD.ToString(@"hh\:mm\:ss tt");
                    tbStartTime.Text = formattedStartTime.Split(' ')[0];

                    TimeSpan endTime = app.EndTime;
                    if (endTime.TotalHours >= 24)
                    {
                        endTime = TimeSpan.FromHours(endTime.TotalHours % 24);
                        origEndTime = endTime;
                    }
                    DateTime endDateTime = DateTime.Today.Add(endTime);
                    string ampmEnd = endTime.Hours >= 12 ? "PM" : "AM";
                    comboEnd.SelectedItem = ampmEnd;
                    string formattedEndTime = endDateTime.ToString(@"hh\:mm\:ss tt");
                    tbEndTime.Text = formattedEndTime.Split(' ')[0];

                    selectedAppointment = app;
                }
            }
            
        }

        private void searchPatient_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchPatient.Text))
            {
                addRows(patientAppointments);
            }
            else
            {
                string text = searchPatient.Text;
                List<Appointment> filtered = new List<Appointment>();
                if (int.TryParse(text, out int id))
                {
                    filtered = patientAppointments.Where(pa => pa.Patient.Patientid == id).ToList();
                }
                else
                {
                    filtered = patientAppointments.Where(pa =>
                    pa.Patient.Firstname.StartsWith(text) ||
                    pa.Patient.Middlename.StartsWith(text) ||
                    pa.Patient.Lastname.StartsWith(text)).ToList();
                }
                addRows(filtered);
            }
        }


        private void TabChanged(object sender, EventArgs e)
        {
            clear();
        }

        private void tbDiagnosis_TextChanged(object sender, EventArgs e)
        {
            string diagnosis = tbDiagnosis.Text;

            if (!string.IsNullOrWhiteSpace(diagnosis))
            {
                int total = limitCharacter - diagnosis.Length;
                if (total == 0)
                {
                    limit.Text = $"You reached limit 200 characters.";
                }
                else
                {
                    limit.Text = $"Up to {total.ToString()} characters.";
                }
            }
        }

        private bool isInputValid()
        {
            if (comboOperations.SelectedIndex == -1)
            {
                MessageBox.Show("Please select operation.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbStartTime.Text) ||
               string.IsNullOrWhiteSpace(tbEndTime.Text))
            {
                MessageBox.Show("Please fill up all fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DateTime selectedDate = datePickerSchedule.Value.Date;

            TimeSpan startTime;
            if (!TimeSpan.TryParseExact(tbStartTime.Text, @"hh\:mm\:ss", null, out startTime))
            {
                MessageBox.Show("Invalid Time, Please enter HH:MM:SS.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DateTime currentDateTime = DateTime.Now;
            DateTime selectedStartDateTime = selectedDate.Add(startTime);
            if (selectedStartDateTime < currentDateTime)
            {
                MessageBox.Show("Time is already past", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            Appointment schedule = new Appointment(dr, selectedDate, startTime, TimeSpan.Parse(tbEndTime.Text));
            bool isScheduleAvailable = db.isScheduleAvailable(schedule);
            

            if (schedule.DateSchedule == selectedAppointment.DateSchedule &&
                  startTime == selectedAppointment.StartTime &&
                  !isScheduleAvailable)
            {
                if (!string.IsNullOrWhiteSpace(tbDiagnosis.Text) &&
                    !tbDiagnosis.Text.Equals(selectedAppointment.Diagnosis, StringComparison.OrdinalIgnoreCase))
                {
                    return true;  
                }
                else
                {
                    MessageBox.Show("Schedule is not available", "Schedule Conflict1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; 
                }
            }




            if (!isScheduleAvailable)
            {
                MessageBox.Show("Schedule is not available", "Schedule Conflict1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void calculateEndTime()
        {
            DateTime startTime;
            if (comboStart.SelectedIndex == -1) return;
            string ampm = comboStart.SelectedItem.ToString();
            string timeInput = tbStartTime.Text + " " + ampm;
            if (DateTime.TryParseExact(timeInput, @"hh\:mm\:ss tt", null, DateTimeStyles.None, out startTime))
            {

                if (tbStartTime.Text.Equals("12:00:00"))
                {
                    MessageBox.Show("Invalid Date 12HRS (00:00:00) - (11:59:00)", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (duration == null) return;
                TimeSpan startTimeSpan = startTime.TimeOfDay;
                origStartTime = startTimeSpan;
                TimeSpan endTime = startTimeSpan + duration;
                if (endTime.TotalHours >= 24)
                {
                    endTime = TimeSpan.FromHours(endTime.TotalHours % 24);
                    origEndTime = endTime;
                }
                DateTime endDateTime = DateTime.Today.Add(endTime);
                string formattedEndTime = endDateTime.ToString(@"hh\:mm\:ss tt");
                tbEndTime.Text = formattedEndTime.Split(' ')[0];
                string ampmEnd = endTime.Hours >= 12 ? "PM" : "AM";
                comboEnd.SelectedItem = ampmEnd;
            }
        }

        private void tbStartTime_TextChanged(object sender, EventArgs e)
        {
            calculateEndTime();
        }
        private TimeSpan origStartTime;
        private TimeSpan origEndTime;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool validInput = isInputValid();
            if (!validInput) return;
            
            DialogResult output = MessageBox.Show("Are you sure you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (output != DialogResult.Yes) return;
            
            TimeSpan startTime;
            if (!TimeSpan.TryParseExact(origStartTime.ToString(), @"hh\:mm\:ss", null, out startTime))
            {
                MessageBox.Show("INVALID TIME Please enter HH:MM:SS", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(tbStartTime.Text.Split(':')[0]) > 12)
            {
                MessageBox.Show("ENTER 12HRS FORMAT", "Invalid Timevv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbStartTime.Text.Equals("12:00:00"))
            {
                MessageBox.Show("Invalid Date 12HRS (00:00:00) - (11:59:00)");
                return;
            }
            TimeSpan endTime = startTime + duration;
            if (endTime.TotalHours >= 24)
            {
                endTime = TimeSpan.FromHours(endTime.TotalHours % 24);

            }

            MessageBox.Show(startTime + "     " + endTime);
            string diagnosis = tbDiagnosis.Text;
            DateTime scheduleDate = datePickerSchedule.Value.Date;
            string operationName = comboOperations.SelectedIndex.ToString();
            Appointment updatedSchedule = new Appointment(scheduleDate, startTime, endTime,
                selectedAppointment.Patient, selectedAppointment.Operation, selectedAppointment.RoomNo, diagnosis, detailId);
            bool success = db.updateSchedule(updatedSchedule);
            if (success)
            {
                patientAppointments = db.getPatients(dr.DoctorID);
                MessageBox.Show("Appointment Updated", "Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateEndTime();
        }
    }
}
