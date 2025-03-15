using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ClinicSystem.PatientForm;
using ClinicSystem.UserLoginForm;

namespace ClinicSystem
{
    public partial class AddPatients : Form
    {
        private PatientDatabase db = new PatientDatabase();
        private Staff staff;
        private List<string> rooms = new List<string>();
      
        public AddPatients(Staff staff)
        {
            this.staff = staff;
            InitializeComponent();
            Gender.Items.Add("Male");
            Gender.Items.Add("Female");
            int id = db.getPatientId();
            lastPatientID.Text = id.ToString();
            rooms = db.getRoomNo();
            foreach (string room in rooms)
            {
                comboRoom.Items.Add(room);
            }
            if (rooms.Count > 0) comboRoom.SelectedIndex = 0; 
        }

        private void BirthDate_Value(object sender, EventArgs e)
        {
            if (DateTime.TryParse(BirthDate.Text, out DateTime birthDate))
            {
                DateTime todayDate = DateTime.Now;
                int age = todayDate.Year - birthDate.Year;

                if (todayDate.Month < birthDate.Month || (todayDate.Month == birthDate.Month && todayDate.Day < birthDate.Day))
                {
                    age--;
                }
                Age.Text = age.ToString();
            }
        }

        private void TextOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void NumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void registerPatient(object sender, EventArgs e)
        {
            string fname = FirstName.Text;
            string mname = MiddleName.Text;
            string lname = LastName.Text;
            string address = Address.Text;
            string age = Age.Text;
            DateTime bday = BirthDate.Value;
            string contact = ContactNo.Text;

            if (string.IsNullOrWhiteSpace(fname) ||
              string.IsNullOrWhiteSpace(mname) ||
              string.IsNullOrWhiteSpace(lname) ||
              string.IsNullOrWhiteSpace(address) ||
              string.IsNullOrWhiteSpace(age) ||
              string.IsNullOrWhiteSpace(bday.ToString()))
            {
                MessageBox.Show("Please fill up all fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboRoom.SelectedItem == null || comboRoom.SelectedIndex == -1)
            {
                MessageBox.Show("Choose room", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Gender.SelectedItem == null || Gender.SelectedIndex == -1)
            {
                MessageBox.Show("Choose gender", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string gender = Gender.SelectedItem.ToString();
            if (bday > DateTime.Now)
            {
                MessageBox.Show("Invalid Birthdate", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ageInt = 0;
            if (!int.TryParse(age, out ageInt))
            {
                MessageBox.Show("Invalid Age", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ageInt > 120 || ageInt < 0)
            {
                MessageBox.Show("Invalid Age", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(contact) && (!long.TryParse(contact, out _) || !Regex.IsMatch(contact, @"^09\d{9}$")))
            {
                MessageBox.Show("Invalid Contact Number", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Patient patient = new Patient(fname, mname, lname, address, ageInt, gender, bday, contact);

            bool success = db.insertPatient(staff.StaffId, patient, comboRoom.SelectedItem.ToString());

            if (success)
            {
             
                MessageBox.Show("Successfully Added Patient", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FirstName.Text = "";
                MiddleName.Text = "";
                LastName.Text = "";
                Address.Text = "";
                Age.Text = "";
                ContactNo.Text = "";
                Gender.SelectedIndex = -1;
                BirthDate.Value = DateTime.Now;
                int id = db.getPatientId();
                lastPatientID.Text = id.ToString();
            }
        }
    }
}
