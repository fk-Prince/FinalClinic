using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicSystem.UserLoginForm;

namespace ClinicSystem.Doctors
{
    public partial class DoctorMainForm : Form
    {
        private Button lastButtonClicked;
        public DoctorMainForm(Staff staff)
        {
            InitializeComponent();
            lastButtonClicked = addDoctorB;
            AddDoctor add = new AddDoctor(staff);
            LoadForm(add);
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
    }
}
