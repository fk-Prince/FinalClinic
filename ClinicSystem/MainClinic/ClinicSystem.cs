using System;
using System.Drawing;
using System.Windows.Forms;
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
            Clock.Text = DateTime.Now.ToString("hh:mm:ss tt");
            Date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DashboardForm dashboard = new DashboardForm(staff,this);
            LoadForm(dashboard);

            lastButtonClicked = DashboardS;
            lastButtonClicked.ForeColor = Color.White;
        }


        private void ViewPatientSide_Click(object sender, EventArgs e)
        {
            ViewPatientForm viewPatientForm = new ViewPatientForm(staff);
            LoadForm(viewPatientForm);
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
                btn.BackColor = Color.FromArgb(119, 136, 152);
                btn.ForeColor = Color.White;
                lastButtonClicked.BackColor = Color.FromArgb(255, 255, 255);
                lastButtonClicked.ForeColor = Color.Black;
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
    }
}