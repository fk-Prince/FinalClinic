using System;

using System.Drawing;
using System.Windows.Forms;
using ClinicSystem.Main2;

namespace ClinicSystem
{
    public partial class DoctorClinics : Form
    {

        private Button lastButtonClicked;
        private Doctor dr;
        private static DoctorClinics instance;
        public DoctorClinics(Doctor dr)
        {
            this.dr = dr;
            instance = this;
            InitializeComponent();
            Clock.Text = DateTime.Now.ToString("hh:mm:ss tt");
            Date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DoctorHome home = new DoctorHome(dr);
            Home.BackColor = Color.FromArgb(111, 163, 216);
            Home.ForeColor = Color.White;
            loadForm(home);
            lastButtonClicked = Home;
           
        }

        public static DoctorClinics getInstance()
        {
            return instance;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void ViewPatientD_Click(object sender, EventArgs e)
        {
            DoctorViewPatient view = new DoctorViewPatient(dr);
            loadForm(view);
        }

        private void loadForm(Form f)
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
                btn.BackColor = Color.FromArgb(111, 163, 216);
                btn.ForeColor = Color.White;
                lastButtonClicked.BackColor = Color.FromArgb(255, 255, 255);
                lastButtonClicked.ForeColor = Color.Black;
                lastButtonClicked = btn;
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            DoctorHome home = new DoctorHome(dr);
            loadForm(home);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoginUserForm login = new LoginUserForm();
            login.Show();
            this.Hide();
        }

        private void SchedulesD_Click(object sender, EventArgs e)
        {
            DoctorAppointmentForm schedule = new DoctorAppointmentForm(dr);
            loadForm(schedule);
        }
    }
}
