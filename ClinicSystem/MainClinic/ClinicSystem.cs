using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicSystem.ClinicHistory;
using ClinicSystem.Doctors;
using ClinicSystem.MainClinic;
using ClinicSystem.Rooms;
using ClinicSystem.UserLoginForm;

namespace ClinicSystem
{
    public partial class ClinicSystem : Form
    {
        private Button lastButtonClicked;
        private Staff staff;
        public ClinicSystem(Staff staff)
        {
            this.staff = staff;
            InitializeComponent();
            StaffIdentity.Text = staff.Username;
            Clock.Text = DateTime.Now.ToString("hh:mm:ss tt");
            Date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DashboardForm dashboard = new DashboardForm(staff,this);
            LoadForm(dashboard);
            button1.Region = System.Drawing.Region.FromHrgn(dll.CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
            lastButtonClicked = DashboardS;
        }

        public void LoadForm(Form f)
        {
            if (mainpanel.Controls.Count > 0)
            {
                mainpanel.Controls.Clear();
            }
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(f);
            mainpanel.Tag = f;
            f.Show();
        }


        private void mouseClicked(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != lastButtonClicked)
            {
                btn.BackColor = Color.FromArgb(19, 30, 46);
                lastButtonClicked.BackColor = Color.FromArgb(26, 42, 64);
                lastButtonClicked = btn;
            }
        }



        private void AddPatientS_Click_1(object sender, EventArgs e)
        {
            FormPatient patientForm = new FormPatient(staff);
            LoadForm(patientForm);
        }


        private void appointmentButton_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm(staff);
            LoadForm(appointmentForm);
        }

        private void OperationClicked(object sender, EventArgs e)
        {
            OperationForm of = new OperationForm(staff);
            LoadForm(of);
        }

        private void roomClicked(object sender, EventArgs e)
        {
            RoomsForm room = new RoomsForm();
            LoadForm(room);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            LoginUserForm user = new LoginUserForm();
            Hide();
            user.Show();
        }

        private void dashboardClicked(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm(staff, this);
            LoadForm(dashboard);
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");
        }

        private void hoursTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            Clock.Text = currentTime.ToString("hh:mm:ss tt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DoctorMainForm doc = new DoctorMainForm(staff);
            LoadForm(doc);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClinicForm clinic = new ClinicForm(staff);
            LoadForm(clinic);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Do you want to logout ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                Hide();
                LoginUserForm user = new LoginUserForm();
                user.Show();
            }
        }
    }
}