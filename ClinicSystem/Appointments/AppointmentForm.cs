using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicSystem.Appointments;
using ClinicSystem.UserLoginForm;

namespace ClinicSystem
{
    public partial class AppointmentForm : Form
    {
        private Staff staff;
        private Button lastButtonClicked;
        public AppointmentForm(Staff staff)
        {
            this.staff = staff;
            InitializeComponent();

            AllAppointments allAppointments = new AllAppointments();
            LoadForm(allAppointments);
            lastButtonClicked = allAppointmentB;
            lastButtonClicked.ForeColor = Color.White;
        }
        public void LoadForm(Form f)
        {
            if (appointmentPanel.Controls.Count > 0)
            {
                appointmentPanel.Controls.Clear();
            }
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            appointmentPanel.Controls.Add(f);
            appointmentPanel.Tag = f;
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

        private void allAppointmentB_Click(object sender, EventArgs e)
        {
            AllAppointments allAppointments = new AllAppointments();
            LoadForm(allAppointments);
        }

        private void addAppointmentB_Click(object sender, EventArgs e)
        {
            AddAppointmentForm add = new AddAppointmentForm(staff);
            LoadForm(add);
        }

        private void rescheduleB_Click(object sender, EventArgs e)
        {
            RescheduleForm add = new RescheduleForm(staff);
            LoadForm(add);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            LoginUserForm user = new LoginUserForm();
            user.Show();
        }
    }
}
