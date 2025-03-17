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
        private static int patientCount = 0;
        private static int doctorCount = 0;
        private int doctorTotal = 0;
        public DashboardForm(Staff staff)
        {
            InitializeComponent();
            Username.Text = staff.Username;
            patientTotal = db.TotalPatientLastMonth();
            ageList = db.getPatients();
            doctorTotal = db.getDoctor();

            if (patientCount >= patientTotal) totalPatient.Text = patientCount.ToString();
            if (doctorCount >= doctorTotal) totalDoctors.Text = doctorCount.ToString();
            

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
    }
}
