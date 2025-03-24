using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ClinicSystem.PatientForm;
using ClinicSystem.UserLoginForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicSystem
{
    public partial class AddPatients : Form
    {
        private PatientDatabase db = new PatientDatabase();
        private Staff staff;
        private List<string> rooms = new List<string>();
        private List<Control> tab = new List<Control>();
        public AddPatients(Staff staff)
        {
            this.staff = staff;
            InitializeComponent();
            Gender.Items.Add("Male");
            Gender.Items.Add("Female");
            int id = db.getPatientId();
            lastPatientID.Text = id.ToString();
            roomSettings();
            button3.Region = System.Drawing.Region.FromHrgn(dll.CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 50, 50));

            tab.Add(FirstName);
            tab.Add(MiddleName);
            tab.Add(LastName); 
            tab.Add(Address);
            tab.Add(Gender);
            tab.Add(BirthDate); 
            tab.Add(ContactNo);
            tab.Add(button3);
        }

        public void roomSettings()
        {
            comboRoom.Items.Clear();
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
                MessagePromp.MainShowMessage(this, "Please fill up all fields", MessageBoxIcon.Error);
                return;
            }

            if (comboRoom.SelectedItem == null || comboRoom.SelectedIndex == -1)
            {
                MessagePromp.MainShowMessage(this, "Choose room", MessageBoxIcon.Error);
                return;
            }

            if (Gender.SelectedItem == null || Gender.SelectedIndex == -1)
            {
                MessagePromp.MainShowMessage(this, "Choose gender", MessageBoxIcon.Error);
                return;
            }

            string gender = Gender.SelectedItem.ToString();
            if (bday > DateTime.Now)
            {
                MessagePromp.MainShowMessage(this, "Invalid Birthdate", MessageBoxIcon.Error);
                return;
            }

            int ageInt = 0;
            if (!int.TryParse(age, out ageInt))
            {
                MessagePromp.MainShowMessage(this, "Invalid Age", MessageBoxIcon.Error);
                return;
            }

            if (ageInt > 120 || ageInt <= 0)
            {
                MessagePromp.MainShowMessage(this, "Invalid Age", MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(contact) && (!long.TryParse(contact, out _) || !Regex.IsMatch(contact, @"^09\d{9}$")))
            {
                MessagePromp.MainShowMessage(this, "Invalid Contact Number", MessageBoxIcon.Error);
                return;
            }

            Patient patient = new Patient(Capitalize(fname), Capitalize(mname), Capitalize(lname), address, ageInt, gender, bday, contact);

            bool success = db.insertPatient(staff.StaffId, patient, comboRoom.SelectedItem.ToString());

            if (success)
            {
                MessagePromp.MainShowMessage(this, "Successfully Added Patient", MessageBoxIcon.Information);
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
                roomSettings();
            }
        }

        public string Capitalize(string name)
        {
            if (string.IsNullOrEmpty(name)) return name;
            return char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }

        private void taab(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                Control currentControl = sender as Control;
                int currentIndex = tab.IndexOf(currentControl);

                if (currentIndex >= 0)
                {
                    int nextIndex = (currentIndex + 1) % tab.Count;
                    tab[nextIndex].Focus();
                    e.IsInputKey = true;
                }
            }
        }
    }
}
