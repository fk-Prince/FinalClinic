using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoctorClinic;

namespace ClinicSystem.Doctors
{
    public partial class ViewDoctor : Form
    {
        private List<Doctor> doctorList;
        private DoctorDatabase db = new DoctorDatabase();
        public ViewDoctor(UserLoginForm.Staff staff)
        {
            InitializeComponent();
            doctorList = db.getDoctors();
            displayDoctors(doctorList);
        }
        public string Capitalize(string name)
        {
            if (string.IsNullOrEmpty(name))
                return name;

            return char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }

        private void displayDoctors(List<Doctor> doctorList)
        {
            flowPanel.Controls.Clear();

            foreach (Doctor doctor in doctorList)
            {
                Panel panel = new Panel();
                panel.Size = new Size(300, 230);
                panel.Location = new Point(50, 100);
                panel.Margin = new Padding(30, 10, 10, 10);
                panel.BackColor = Color.FromArgb(111, 163, 216);
                panel.Region = Region.FromHrgn(dll.CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 50, 50));

                PictureBox picture = new PictureBox();
                picture.Image = Properties.Resources.doctor_test;
                picture.Location = new Point(15,10);
                picture.Size = new Size(64, 64);
                panel.Controls.Add(picture);
                

                Label label = createLabel("Doctor ID", doctor.DoctorID.ToString(), 10, 80);
                panel.Controls.Add(label);

                string fullname = Capitalize(doctor.DoctorFirstName) + "  " + Capitalize(doctor.DoctorMiddleName) + "  " + Capitalize(doctor.DoctorLastName);
                label = createLabel("Doctor Name", fullname, 10, 100);
                panel.Controls.Add(label);

                label = createLabel(
                    "Age", 
                    doctor.DoctorAge.ToString(),
                    10,
                    120
                );
                panel.Controls.Add(label);

                label = createLabel("Gender", doctor.Gender, 10, 140);
                panel.Controls.Add(label);

                label = createLabel("Date-Hired", doctor.DateHired.ToString("yyyy-MM-dd"), 10, 160);
                panel.Controls.Add(label);

                label = createLabel("Address", doctor.DoctorAddress, 10, 180);
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

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            List<Doctor> filteredDoctor = new List<Doctor>();
            if (string.IsNullOrWhiteSpace(SearchBar.Text))
            {
                filteredDoctor = doctorList;
            }
            else
            {

                filteredDoctor = doctorList.Where(
                   doctor =>
                   doctor.DoctorFirstName.StartsWith(SearchBar.Text, StringComparison.OrdinalIgnoreCase) ||
                   doctor.DoctorLastName.StartsWith(SearchBar.Text, StringComparison.OrdinalIgnoreCase) ||
                   doctor.DoctorID.ToString().StartsWith(SearchBar.Text, StringComparison.OrdinalIgnoreCase)
               ).ToList();

            }
            displayDoctors(filteredDoctor);
        }
    }
}
