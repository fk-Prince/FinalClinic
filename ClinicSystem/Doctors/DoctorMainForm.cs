using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicSystem.UserLoginForm;

namespace ClinicSystem.Doctors
{
    public partial class DoctorMainForm : Form
    {
        private Button lastButtonClicked;
        private Staff staff;
        public DoctorMainForm(Staff staff)
        {
            this.staff = staff;
            InitializeComponent();
            lastButtonClicked = addDoctorB;
            ViewDoctor view = new ViewDoctor(staff);
            view.BackColor = Color.FromArgb(119, 136, 152);
            view.ForeColor = Color.White;
            LoadForm(view);
        }

        public void LoadForm(Form f)
        {
            if (doctorpanel.Controls.Count > 0)
            {
                doctorpanel.Controls.Clear();
            }
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            doctorpanel.Controls.Add(f);
            doctorpanel.Tag = f;
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

        private void addDoctorB_Click(object sender, EventArgs e)
        {
            AddDoctor add = new AddDoctor(staff);
            LoadForm(add);
        }

        private void viewDoctorB_Click(object sender, EventArgs e)
        {
            ViewDoctor view = new ViewDoctor(staff);
            LoadForm(view);
        }
    }
}
