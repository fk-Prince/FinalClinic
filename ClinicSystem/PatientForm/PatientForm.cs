using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicSystem.UserLoginForm;

namespace ClinicSystem
{

    public partial class FormPatient : Form
    {
        private Button lastClickedButton;
        private Staff staff;
        public FormPatient(Staff staff)
        {
            this.staff = staff;
            InitializeComponent();
            lastClickedButton = addPatient;
            AddPatients addPatientForm = new AddPatients(staff);
            loadForm(addPatientForm);

        }

        private void loadForm(Form f)
        {
            if (patientPanel.Controls.Count > 0)
            {
                patientPanel.Controls.Clear();
            }
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            patientPanel.Controls.Add(f);
            patientPanel.Tag = f;
            f.Show();
        }

        private void mouseClicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != lastClickedButton)
            {
                btn.BackColor = Color.FromArgb(119, 136, 152);
                btn.ForeColor = Color.White;
                lastClickedButton.BackColor = Color.FromArgb(255, 255, 255);
                lastClickedButton.ForeColor = Color.Black;
                lastClickedButton = btn;
            }
        }

        private void addPatientClicked(object sender, MouseEventArgs e)
        {
            AddPatients addPatientForm = new AddPatients(staff);
            loadForm(addPatientForm);
        }

        private void viewPatientClicked(object sender, MouseEventArgs e)
        {
            ViewPatientForm addPatientForm = new ViewPatientForm(staff);
            loadForm(addPatientForm);
        }

    }
}
