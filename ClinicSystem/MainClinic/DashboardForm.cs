using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public DashboardForm(Staff staff)
        {
            InitializeComponent();
            Username.Text = staff.Username;
            patientTotal = db.TotalPatientLastMonth();
            ageList = db.getPatients();
            doctorTotal = db.getDoctor();
            Dictionary<string, int> ageRange = new Dictionary<string, int>
                {
                    { "Lower 10", 0 },
                    { "Lower 20", 0 },
                    { "Lower 30", 0 },
                    { "Lower 40", 0 },
                    { "Lower 50", 0 },
                    { "Lower 60", 0 },
                    { "Above 70", 0 }
                };

            foreach (int age in ageList)
            {
                if (age <= 10) ageRange["Lower 10"]++;
                else if (age <= 20) ageRange["Lower 20"]++;
                else if (age <= 30) ageRange["Lower 30"]++;
                else if (age <= 40) ageRange["Lower 40"]++;
                else if (age <= 50) ageRange["Lower 50"]++;
                else if (age <= 60) ageRange["Lower 60"]++;
                else ageRange["Above 70"]++;
            }

            foreach (var age in ageRange)
            {
                chartAge.Series["Age"].Points.AddXY(age.Key, age.Value);
            }
            chartAge.ChartAreas[0].AxisY.Minimum = 0; 
            chartAge.ChartAreas[0].AxisY.Interval = 1; 
            chartAge.ChartAreas[0].AxisY.LabelStyle.Format = "0";
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
            if (doctorTotal  == 0)
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
