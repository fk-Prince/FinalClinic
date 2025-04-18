﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ClinicSystem.DoctorClinic;
using ClinicSystem.UserLoginForm;
using DoctorClinic;

namespace ClinicSystem
{
    public partial class DoctorViewPatient : Form
    {
        private List<Appointment> patientAppointments;
        private DoctorDatabase db = new DoctorDatabase();
        private DataGridViewRow lastSelectedRow = null;
        private DataTable dt;
        private Doctor dr;

        private int limitCharacter = 200;
        private List<Appointment> filtered = new List<Appointment>();
        private Appointment selectedAppointment;
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

            comboStart.Items.Add("AM");
            comboStart.Items.Add("PM");
            comboEnd.Items.Add("AM");
            comboEnd.Items.Add("PM");
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
            comboStart.Items.Clear();
            comboEnd.Items.Clear();
            comboOpNo.Items.Clear();
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

            comboStart.Items.Add("AM");
            comboStart.Items.Add("PM");
            comboEnd.Items.Add("AM");
            comboEnd.Items.Add("PM");
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
                    comboOpNo.Items.Add(pas.AppointmentDetailNo);
                }
            }
        }

        private void comboOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboOpNo.SelectedIndex == -1) return;
            if (comboOperations.SelectedIndex == -1) return;
            string operationName = comboOperations.SelectedItem.ToString();
            int appointmentDetailNo = int.Parse(comboOpNo.SelectedItem.ToString());
            foreach (Appointment app in filtered)
            {
                if (app.AppointmentDetailNo == appointmentDetailNo && app.Operation.OperationName.Equals(operationName))
                {
                    datePickerSchedule.Value = app.DateSchedule;
                    tbDiagnosis.Text = app.Diagnosis;
                    calculateStartEndTime(app);
                    break;
                }
            }
        }

        private void calculateStartEndTime(Appointment app)
        {
            TimeSpan startTime = app.StartTime;
            DateTime startDateTime = DateTime.Today.Add(startTime);
            //string formatStartTime;
            //if (startDateTime.ToString("HH:mm:ss") == "00:00:00")
            //{
            //    formatStartTime = "00:00:00 AM";
            //}
            //else
            //{
            //    formatStartTime = startDateTime.ToString("hh:mm:ss tt");
            //}
            string formatStartTime = startDateTime.ToString("hh:mm:ss tt");
            tbStartTime.Text = formatStartTime.Split(' ')[0];
            string ampmStart = formatStartTime.Split(' ')[1];
            comboStart.SelectedItem = ampmStart;

            TimeSpan endTime = app.EndTime;
            DateTime endDateTime = DateTime.Today.Add(endTime);
            //string formatEndTime;
            //if (endDateTime.ToString("HH:mm:ss") == "00:00:00")
            //{
            //    formatEndTime = "00:00:00 AM";
            //}
            //else
            //{
            //    formatEndTime = endDateTime.ToString("hh:mm:ss tt");
            //}
            string formatEndTime = endDateTime.ToString("hh:mm:ss tt");
            tbEndTime.Text = formatEndTime.Split(' ')[0];
            string ampmEnd = formatEndTime.Split(' ')[1];
            comboEnd.SelectedItem = ampmEnd;
        }

        private void comboOpNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboOpNo.SelectedIndex == -1) return;
            int appointmentDetailNo = int.Parse(comboOpNo.SelectedItem.ToString());
            foreach (Appointment app in filtered)
            {
                if (app.AppointmentDetailNo == appointmentDetailNo)
                {
                    selectedAppointment = app;
                    comboOperations.Items.Add(app.Operation.OperationName);
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Appointment updatedSchedule = new Appointment(selectedAppointment.DateSchedule, selectedAppointment.StartTime, selectedAppointment.EndTime,
                selectedAppointment.Patient, selectedAppointment.Operation, selectedAppointment.RoomNo, tbDiagnosis.Text, selectedAppointment.AppointmentDetailNo);
            bool success = db.updateSchedule(updatedSchedule);
            if (success)
            {
                patientAppointments = db.getPatients(dr.DoctorID);
                MessagePromp.MainShowMessage(this, "Diagnosis Recorded.", MessageBoxIcon.Information);
            }

        }

    }
}
