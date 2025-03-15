using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ClinicSystem.PatientForm;
using ClinicSystem.UserLoginForm;

namespace ClinicSystem.Appointments
{
    public partial class AddAppointmentForm : Form
    {
        private PatientDatabase db = new PatientDatabase();
        private Staff staff;
        private List<Operation> operationList;
        private List<string> operationNameAddedList = new List<string>();
        private List<Doctor> doctorList;
        private List<Patient> patientList;
        private List<Appointment> temporaryStorage = new List<Appointment>();
        private List<Appointment> patientSchedules = new List<Appointment>();
        private List<DoctorOperation> docOp = new List<DoctorOperation>();
        private Stack<string> text = new Stack<string>();
     /*   text.Clear();
            temporaryStorage.Clear();
            patientSchedules.Clear();
            docOp.Clear();
            comboPatientID.Items.Clear();
            comboOperation.Items.Clear();*/
        private Operation selectedOperation;
        private Doctor selectedDoctor;
        private Patient selectedPatient;
        private Operation lastSelected;
        public AddAppointmentForm(Staff staff)
        {
            this.staff = staff;
            InitializeComponent();
            patientList = db.getPatients();
            foreach (Patient patient in patientList)
            {
                comboPatientID.Items.Add(patient.Patientid);
            }
        }

        private void operationSettings()
        {
            operationList = db.getOperations();
            if (operationList != null && operationList.Count != 0)
            {
                foreach (Operation operation in operationList)
                {
                    comboOperation.Items.Add(operation.OperationName);
                }
            }
            else
            {
                comboOperation.Items.Add("No Operation Available");
            }
            comboOperation.SelectedIndex = -1;
        }

        private void comboOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDoctor.Items.Clear();
            if (comboOperation == null || comboOperation.SelectedItem == null) return;
            string operationNameSelected = comboOperation.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(operationNameSelected)) return;

            selectedOperation = null;
            foreach (Operation operation in operationList)
            {
                if (operation.OperationName.Equals(operationNameSelected, StringComparison.OrdinalIgnoreCase))
                {
                    selectedOperation = operation;
                    break;
                }
            }

            doctorList = db.getDoctors(selectedOperation);
            if (doctorList != null && doctorList.Count != 0)
            {
                foreach (Doctor doctor in doctorList)
                {
                    comboDoctor.Items.Add(doctor.DoctorID + ",   " + doctor.DoctorLastName + ", " + doctor.DoctorFirstName + " " + doctor.DoctorMiddleName);
                }
            }
            else
            {
                comboDoctor.Items.Add("No Doctor Available");
            }
            comboDoctor.SelectedIndex = 0;
            calculateEndTime();
        }

        private void StartTime_TextChanged(object sender, EventArgs e)
        {
            calculateEndTime();
        }
        private void calculateEndTime()
        {
            DateTime startTime;
            if (comboStart.SelectedIndex == -1) return;
            string ampm = comboStart.SelectedItem.ToString();
            string timeInput = StartTime.Text + " " + ampm;
            if (DateTime.TryParseExact(timeInput, @"hh\:mm\:ss tt", null, DateTimeStyles.None, out startTime))
            {
                if (StartTime.Text.Equals("12:00:00"))
                {
                    MessageBox.Show("Invalid Date 12HRS (00:00:00) - (11:59:00)", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (selectedOperation == null) return;
                TimeSpan startTimeSpan = startTime.TimeOfDay;
                origStartTime = startTimeSpan;
                TimeSpan endTime = startTimeSpan + selectedOperation.Duration;

                if (endTime.TotalHours >= 24)
                {
                    endTime = TimeSpan.FromHours(endTime.TotalHours % 24);
                    origEndTime = endTime;
                }

                DateTime endDateTime = DateTime.Today.Add(endTime);
                string formattedEndTime = endDateTime.ToString(@"hh\:mm\:ss tt");
                EndTime.Text = formattedEndTime.Split(' ')[0];
                string ampmEnd = endTime.Hours >= 12 ? "PM" : "AM";
                comboEnd.SelectedItem = ampmEnd;
            } 
        }
         
        private TimeSpan origStartTime;
        private TimeSpan origEndTime;

        private void Add_Click(object sender, EventArgs e)
        {
            bool valid = isComboValid();
            if (!valid) return;

            bool duplicate = isAlreadyAdded();
            if (duplicate) return;

            TimeSpan startTime;
            if (!TimeSpan.TryParseExact(origStartTime.ToString(), @"hh\:mm\:ss", null, out startTime))
            {
                MessageBox.Show("Invalid time, Please enter valid time(hh:mm:ss).", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(StartTime.Text.Split(':')[0]) >= 12)
            {
                MessageBox.Show("Enter 12 hours format (00:00:00) - (11:59:00).", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DateTime selectedDate = this.scheduleDate.Value.Date;
            DateTime currentDateTime = DateTime.Now;
            DateTime selectedStartDateTime = selectedDate.Add(startTime);
            if (selectedStartDateTime < currentDateTime)
            {
                MessageBox.Show("Time is already past", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string scheduleDate = selectedDate.ToString("yyyy-MM-dd");
            TimeSpan endTime = startTime + selectedOperation.Duration;
            if (endTime.TotalHours >= 24)
            {
                endTime = TimeSpan.FromHours(endTime.TotalHours % 24);

            }

            Appointment schedule = new Appointment(selectedDoctor, selectedDate, startTime, endTime);
            bool isScheduleAvailable = db.isScheduleAvailable(schedule);
            if (!isScheduleAvailable)
            {
                MessageBox.Show("Schedule conflicts with the doctor schedule.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Appointment sc in patientSchedules)
            {
                if (sc.Patient.Patientid == selectedPatient.Patientid && sc.DateSchedule.Date == selectedDate.Date &&
                    (startTime < sc.EndTime && endTime > sc.StartTime))
                {
                    MessageBox.Show("Schedule conflicts with the your schedule.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Appointment pschedule = new Appointment(selectedPatient, selectedDate, startTime, endTime);
            patientSchedules.Add(pschedule);


            foreach (Appointment sc in temporaryStorage)
            {
                if (sc.Doctor.DoctorID == selectedDoctor.DoctorID && sc.DateSchedule.Date == selectedDate.Date &&
                    (startTime < sc.EndTime && endTime > sc.StartTime))
                {
                    MessageBox.Show("Schedule conflicts with the doctor schedule.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            temporaryStorage.Add(schedule);
            operationNameAddedList.Add(selectedOperation.OperationName);
            displayOperationAdded(schedule);
            MessageBox.Show("Operation Added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            docOp.Add(new DoctorOperation(selectedDoctor, selectedOperation, schedule));
            calculateTotalBill();
            lastSelected = selectedOperation;
        }

        private void calculateTotalBill()
        {
            double totalBill = 0;
            foreach (DoctorOperation doc in docOp)
            {
                totalBill += doc.Operation.Price;
            }
            TotalBill.Text = totalBill.ToString("F2");
        }

        private bool isAlreadyAdded()
        {
            if (temporaryStorage != null && temporaryStorage.Count != 0)
            {
                foreach (Appointment vb in temporaryStorage)
                {
                    if (operationNameAddedList.Contains(selectedOperation.OperationName))
                    {
                        MessageBox.Show("This operation is already added.", "Duplicate Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                }
            }

            return false;
        }

        private void displayOperationAdded(Appointment schedule)
        {
            string fullname = schedule.Doctor.DoctorLastName + ", " + schedule.Doctor.DoctorFirstName + " " + schedule.Doctor.DoctorMiddleName;
            string displayText = $"Operation Name:  {selectedOperation.OperationName}  {Environment.NewLine}"  +
                                 $"Doctor Assigned: {fullname}  {Environment.NewLine}" +  
                                 $"Date Schedule: {schedule.DateSchedule.ToString("yyyy-MM-dd")} {Environment.NewLine}" +
                                 $"StartTime: {StartTime.Text} {comboStart.SelectedItem.ToString()}{Environment.NewLine}" +
                                 $"EndTime:  {EndTime.Text} {comboEnd.SelectedItem.ToString()}{Environment.NewLine}" +
                                 "------------------------------------------------------------------------------------------------------------" + Environment.NewLine;
            tbListOperation.Text += displayText;
            text.Push(displayText);
        }

        private bool isComboValid()
        {
            if (comboOperation.SelectedItem == null || string.IsNullOrWhiteSpace(comboOperation.SelectedItem.ToString()))
            {
                MessageBox.Show("No Operation Selected", "No Operation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            if (comboOperation.SelectedItem.Equals("No Operation Available"))
            {
                MessageBox.Show("No Operation Available", "No Operation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            if (comboDoctor.SelectedItem == null || string.IsNullOrWhiteSpace(comboDoctor.SelectedItem.ToString()))
            {
                MessageBox.Show("No Doctor Selected", "No Doctor", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            if (comboDoctor.SelectedItem.Equals("No Doctor Available"))
            {
                MessageBox.Show("No Doctor Available", "No Doctor", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void comboPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPatientID.SelectedIndex == -1) return;
            text.Clear();
            temporaryStorage.Clear();
            patientSchedules.Clear();
            docOp.Clear();
            comboOperation.Items.Clear();
            comboDoctor.Items.Clear();
            TotalBill.Text = "";
            StartTime.Text = "";
            EndTime.Text = "";
            tbListOperation.Text = "";
            if (selectedDoctor != null) selectedDoctor = null;
            if (selectedOperation != null) selectedOperation = null;
            if (selectedPatient != null) selectedPatient = null;
            if (lastSelected != null) lastSelected = null;
            string pat = comboPatientID.SelectedItem.ToString();
            foreach (Patient patient in patientList)
            {
                if (patient.Patientid == int.Parse(pat))
                {
                    selectedPatient = patient;
                    fName.Text = patient.Firstname;
                    mName.Text = patient.Middlename;
                    lName.Text = patient.Lastname;
                    break;
                }
            }
            string opNumber = db.getPatientOperationNo();
            PatientAppointmentNo.Text = opNumber;
            comboStart.Items.Clear(); 
            comboEnd.Items.Clear();
            comboStart.Items.Add("AM");
            comboStart.Items.Add("PM");
            comboStart.SelectedIndex = 0;
            comboEnd.Items.Add("AM");
            comboEnd.Items.Add("PM");
            
            operationSettings();
        }

        private void comboDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDoctor.SelectedIndex == -1) return;
            string[] doc = comboDoctor.SelectedItem.ToString().Split(',');
            if (doctorList != null && doctorList.Count != 0)
            {
                foreach (Doctor doctor in doctorList)
                {
                    if (int.Parse(doc[0]) == doctor.DoctorID)
                    {
                        selectedDoctor = doctor;
                    }
                }
            }
        }

        private void RemoveStack_Click(object sender, EventArgs e)
        {
            if (text == null || text.Count == 0) return;
            text.Pop();
            tbListOperation.Text = "";
            foreach (string t in text)
            {
                tbListOperation.Text += t;
            }

            if (temporaryStorage.Count >= 0)
            {
                Appointment lastSchedule = temporaryStorage.Last();
                temporaryStorage.Remove(lastSchedule);

                if (double.TryParse(TotalBill.Text, out double bill))
                {
                    bill -= lastSelected.Price;
                    TotalBill.Text = bill.ToString("F2");
                }
            }

            if (patientSchedules.Count > 0)
            {
                Appointment lastPatientSchedule = patientSchedules.Last();
                patientSchedules.Remove(lastPatientSchedule);
            }

            foreach (string t in text)
            {
                tbListOperation.Text += t;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedPatient == null)
            {
                MessageBox.Show("Please Select a Patient", "No Patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (docOp.Count <= 0)
            {
                MessageBox.Show("Please Select Operation", "No Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double bill = double.Parse(TotalBill.Text);
            
            bool success = db.AddAppointment(selectedPatient, docOp, bill);
            if (success)
            {
                MessageBox.Show("Appoinment Added", "Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboPatientID.SelectedIndex = -1;
                comboOperation.SelectedIndex = -1;
                comboDoctor.SelectedIndex = -1;
                scheduleDate.Value = DateTime.Now;
                StartTime.Text = "";
                EndTime.Text = "";
                TotalBill.Text = "";
                text.Clear();
                tbListOperation.Text = "";
                selectedDoctor = null;
                selectedOperation = null;
                selectedPatient = null;
                lastSelected = null;
                temporaryStorage.Clear();
                patientSchedules.Clear();
                docOp.Clear();
                comboPatientID.Items.Clear();
                comboOperation.Items.Clear();
                patientList = db.getPatients();
                foreach (Patient patient in patientList)
                {
                    comboPatientID.Items.Add(patient.Patientid);
                }
            }
        }

        private void comboStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateEndTime();
        }
    }
}
