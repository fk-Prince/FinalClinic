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
            panel4.Region = System.Drawing.Region.FromHrgn(dll.CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 50, 50));
            panel8.Region = System.Drawing.Region.FromHrgn(dll.CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 50, 50));
            button1.Region = System.Drawing.Region.FromHrgn(dll.CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));

        }
        private void lastMonthTimer_Tick(object sender, EventArgs e)
        {
            if (patientTotal == 0)
            {
                lastMonthTotal.Text = "0";
                lastMonthTimer.Stop();
            }
            if (patientCount > patientTotal)
            {
                lastMonthTimer.Stop();
                return;
            }
            lastMonthTotal.Text = patientCount.ToString();
            patientCount++;
        }

        private void doctorT_Tick(object sender, EventArgs e)
        {
            if (doctorTotal == 0)
            {
                totalDoctor.Text = "0";
                doctorT.Stop();
            }
            if (doctorCount > doctorTotal)
            {
                doctorT.Stop();
                return;
            }
            totalDoctor.Text = doctorCount.ToString();
            doctorCount++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Do you want to logout ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                f.Hide();
                LoginUserForm user = new LoginUserForm();
                user.Show();
            }
        }
    }
}
