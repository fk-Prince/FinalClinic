using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ClinicSystem.PatientForm;
using ClinicSystem.Rooms;
using ClinicSystem.UserLoginForm;
using Google.Protobuf.WellKnownTypes;

namespace ClinicSystem.Appointments
{
    public partial class AddAppointmentForm : Form
    {
        private AppointmentDatabase db = new AppointmentDatabase();
        private Staff staff;
        private List<Operation> operationList;
        private List<string> operationNameAddedList = new List<string>();
        private List<Doctor> doctorList;
        private List<Patient> patientList;
        private List<Appointment> temporaryStorage = new List<Appointment>();
        private List<Appointment> patientSchedules = new List<Appointment>();
        private Stack<string> text = new Stack<string>();
        private List<Room> rooms = new List<Room>();


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
            button1.Region = System.Drawing.Region.FromHrgn(dll.CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            rooms = db.getRoomNo();
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
                    comboRoom.Items.Clear();
                    selectedOperation = operation;
                    List<Room> filter = new List<Room>();
                    foreach (Room room in rooms)
                    {
                        if (operation.OperationRoomType.Equals(room.Roomtype))
                        {
                            filter.Add(room);
                            comboRoom.Items.Add(room.RoomNo + " | " + room.Roomtype);
                        }
                    }
                    if (filter.Count == 0) comboRoom.Items.Add("No Room Available");
                    comboRoom.SelectedIndex = 0;
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
                if (StartTime.Text.Contains("12:00:00"))
                {
                    MessagePromp.MainShowMessageBig(this, "Invalid Date 12HRS (00:00:00) - (11:59:00)", MessageBoxIcon.Error);
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

            if (comboRoom.SelectedItem.ToString().Equals("No Room Available"))
            {
                MessagePromp.MainShowMessageBig(this, "No Room Available.", MessageBoxIcon.Error);
                return;
            }

            if (comboRoom.SelectedIndex == -1)
            {
                MessagePromp.MainShowMessageBig(this, "Please select room.", MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(StartTime.Text))
            {
                MessagePromp.MainShowMessageBig(this, "Please fill the start-time.", MessageBoxIcon.Error);
                return;
            }

            TimeSpan startTime;
            if (!TimeSpan.TryParseExact(origStartTime.ToString(), "hh\\:mm\\:ss", null, out startTime))
            {
                MessageBox.Show(origStartTime.ToString());
                MessagePromp.MainShowMessageBig(this, "Invalid time, Please enter valid time(hh:mm:ss).", MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(StartTime.Text.Split(':')[0]) >= 12)
            {
                MessagePromp.MainShowMessageBig(this, "Enter 12 hours format (00:00:00) - (11:59:00).", MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(StartTime.Text.Split(':')[1]) >= 60 || int.Parse(StartTime.Text.Split(':')[2]) >= 60)
            {
                MessagePromp.MainShowMessageBig(this, "Minutes and seconds must be between 00 and 59.", MessageBoxIcon.Error);
                return;
            }


            DateTime selectedDate = this.scheduleDate.Value.Date;
            DateTime currentDateTime = DateTime.Now;
            DateTime selectedStartDateTime = selectedDate.Add(startTime);
            if (selectedStartDateTime < currentDateTime)
            {
                MessagePromp.MainShowMessageBig(this, "Time is already past.", MessageBoxIcon.Error);
                return;
            }

            string scheduleDate = selectedDate.ToString("yyyy-MM-dd");
            TimeSpan endTime = startTime + selectedOperation.Duration;
            if (endTime.TotalHours >= 24)
            {
                endTime = TimeSpan.FromHours(endTime.TotalHours % 24);
            }

            foreach (Appointment sc in patientSchedules)
            {
                if (sc.Patient.Patientid == selectedPatient.Patientid && sc.DateSchedule.Date == selectedDate.Date &&
                    (startTime < sc.EndTime && endTime > sc.StartTime))
                {
                    MessagePromp.MainShowMessageBig(this, "Schedule conflicts with the patient schedule.", MessageBoxIcon.Error);
                    return;
                }
            }  
            int roomno = int.Parse(comboRoom.SelectedItem.ToString().Split(' ')[0].Trim());
            Appointment pschedule = new Appointment(selectedPatient, selectedDoctor, selectedOperation, selectedDate, startTime, endTime, selectedOperation.Price, roomno);

            bool patientavailable = db.isPatientAvailable(pschedule);
            if (!patientavailable)
            {
                MessagePromp.MainShowMessageBig(this, "Schedule conflicts with the patient schedule.", MessageBoxIcon.Error);
                return;
            }

            bool isRoomAvailable = db.isRoomAvailable(roomno, selectedDate,startTime,endTime);
            if (!isRoomAvailable)
            {
                MessagePromp.MainShowMessageBig(this, "Room is not available during this time.", MessageBoxIcon.Error);
                return;
            }


            Appointment schedule = new Appointment(selectedDoctor, selectedDate, startTime, endTime,roomno);


            bool isScheduleAvailable = db.isScheduleAvailable(schedule);
            if (!isScheduleAvailable)
            {
                MessagePromp.MainShowMessageBig(this, "Schedule conflicts with the doctor schedule.", MessageBoxIcon.Error);
                return;
            }

            //foreach (Appointment sc in patientSchedules)
            //{
            //    if (sc.Patient.Patientid == selectedPatient.Patientid && sc.DateSchedule.Date == selectedDate.Date &&
            //        (startTime < sc.EndTime && endTime > sc.StartTime))
            //    {
            //        MessagePromp.MainShowMessageBig(this, "Schedule conflicts with the patient schedule.", MessageBoxIcon.Error);
            //        return;
            //    }
            //}
            //Appointment pschedule = new Appointment(selectedPatient, selectedDoctor, selectedOperation, selectedDate, startTime, endTime, selectedOperation.Price, roomno);

            //bool patientavailable = db.isPatientAvailable(pschedule);
            //if (!patientavailable)
            //{
            //    MessagePromp.MainShowMessageBig(this, "Schedule conflicts with the patient schedule.", MessageBoxIcon.Error);
            //    return;
            //}

            patientSchedules.Add(pschedule);


            foreach (Appointment sc in temporaryStorage)
            {
                if (sc.Doctor.DoctorID == selectedDoctor.DoctorID && sc.DateSchedule.Date == selectedDate.Date &&
                    (startTime < sc.EndTime || endTime > sc.StartTime))
                {
                    MessagePromp.MainShowMessageBig(this, "Schedule conflicts with the doctor schedule.", MessageBoxIcon.Error);
                    return;
                }
            }
            temporaryStorage.Add(schedule);
            operationNameAddedList.Add(selectedOperation.OperationName);

            displayOperationAdded(schedule);
            MessagePromp.MainShowMessage(this, "Operation Added.", MessageBoxIcon.Information);
            calculateTotalBill();
            string opNumber = db.getAppointmentDetail();
            PatientAppointmentNo.Text = (int.Parse(opNumber) + 1).ToString();
            lastSelected = selectedOperation;
        }

        private void calculateTotalBill()
        {
            double totalBill = 0;
            foreach (Appointment ap in patientSchedules)
            {
                totalBill += ap.Bill;
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
                        MessagePromp.MainShowMessageBig(this, "This operation is already added.", MessageBoxIcon.Error);
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
                                 $"Operation Bill:  {selectedOperation.Price.ToString("F2")}  {Environment.NewLine}" +
                                 $"Doctor Assigned: Dr.{fullname}  {Environment.NewLine}" +
                                 $"Date Schedule: {schedule.DateSchedule.ToString("yyyy-MM-dd")} {Environment.NewLine}" +
                                 $"RoomNo:  {schedule.RoomNo} {Environment.NewLine}" +
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
                MessagePromp.MainShowMessage(this, "No Operation Selected.", MessageBoxIcon.Error);
                return false;
            }
            if (comboOperation.SelectedItem.Equals("No Operation Available"))
            {
                MessagePromp.MainShowMessage(this, "No Operation Available.", MessageBoxIcon.Error);
                return false;
            }
            if (comboDoctor.SelectedItem == null || string.IsNullOrWhiteSpace(comboDoctor.SelectedItem.ToString()))
            {
                MessagePromp.MainShowMessage(this, "No Doctor Selected.", MessageBoxIcon.Error);
                return false;
            }
            if (comboDoctor.SelectedItem.Equals("No Doctor Available"))
            {
                MessagePromp.MainShowMessage(this, "No Doctor Available.", MessageBoxIcon.Error);
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
            comboOperation.Items.Clear();
            comboDoctor.Items.Clear();
            operationNameAddedList.Clear();
            comboRoom.Items.Clear();
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
            string opNumber = db.getAppointmentDetail();
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
                MessagePromp.MainShowMessage(this, "Please Select a Patient.", MessageBoxIcon.Error);          
                return;
            }

            if (patientSchedules.Count <= 0)
            {
                MessagePromp.MainShowMessage(this, "Please Add an Operation.", MessageBoxIcon.Error);
                return;
            }

            double bill = double.Parse(TotalBill.Text);
            
            bool success = db.AddAppointment(selectedPatient, patientSchedules);
            if (success)
            {
                MessagePromp.MainShowMessage(this, "Appoinment Added", MessageBoxIcon.Information);
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
                comboRoom.Items.Clear();
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
