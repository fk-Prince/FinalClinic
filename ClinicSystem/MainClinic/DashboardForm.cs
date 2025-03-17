using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ClinicSystem.UserLoginForm;

namespace ClinicSystem.MainClinic
{
    public partial class DashboardForm : Form
    {
        private ClinicDatabase db = new ClinicDatabase();
        private List<int> ageList;
        private int patientTotal = 0;
        private int patientCount = 0;
        private int doctorCount = 0;
        private int doctorTotal = 0;
        private Form f;
        public DashboardForm(Staff staff, Form f)
        {
            this.f = f;
            InitializeComponent();
            Username.Text = staff.Username;
            patientTotal = db.TotalPatientLastMonth();
            ageList = db.getPatients();
            doctorTotal = db.getDoctor();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginUserForm user = new LoginUserForm();
            user.Show();
        }

        private void lastMonthTimer_Tick(object sender, EventArgs e)
        {
            if (patientTotal == 0)
            {
                totalPatient.Text = "0";
                lastMonthTimer.Stop();
            }
            if (patientCount > patientTotal)
            {
                lastMonthTimer.Stop();
                return;
            }
            totalPatient.Text = patientCount.ToString();
            patientCount++;
        }

        private void doctorT_Tick(object sender, EventArgs e)
        {
            if (doctorTotal == 0)
            {
                totalDoctors.Text = "0";
                doctorT.Stop();
            }
            if (doctorCount > doctorTotal)
            {
                doctorT.Stop();
                return;
            }
            totalDoctors.Text = doctorCount.ToString();
            doctorCount++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.Hide();
            LoginUserForm user = new LoginUserForm();
            user.Show();
        }
    }
}
