using System;
using ClinicSystem.UserLoginForm;
using System.Windows.Forms;
using System.Data;

namespace ClinicSystem
{
    public partial class ViewPatientForm : Form
    {
        public ViewPatientForm(Staff staff)
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("Room No", typeof(string));
            dt.Columns.Add("Patient ID", typeof(int));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Middle Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Contact Number", typeof(string));
            dataGridView.DataSource = dt;

            //dt.Rows.Add("101", 1, "Sample", "Sample", "Sample", 30, "Male", "09771171913");
            //dt.Rows.Add("102", 2, "Sample", "Sample", "Sample", 25, "Female", "09771171913");
        }
    }
}
