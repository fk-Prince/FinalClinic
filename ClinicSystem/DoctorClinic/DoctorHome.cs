using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicSystem
{
    public partial class DoctorHome : Form
    {
        private Doctor dr;
        private List<Operation> operations = new List<Operation>();
        private DataBaseOperation db = new DataBaseOperation();
        public DoctorHome(Doctor dr)
        {
            this.dr = dr;
            InitializeComponent();
            DoctorID.Text = dr.DoctorID.ToString();
            DoctorFullName.Text += dr.DoctorFirstName + "  " + dr.DoctorMiddleName + "  " + dr.DoctorLastName;
            Age.Text = dr.DoctorAge.ToString();
            Address.Text = dr.DoctorAddress;
            Gender.Text = dr.Gender;
            DateHired.Text = dr.DateHired.ToString("yyyy-MM-dd");
            operations = db.getOperationByDoctor(dr.DoctorID);

            foreach (Operation op in operations)
            {
                specialized.Text += "Operation Code:  " + op.OperationCode + Environment.NewLine + "Operation Name:  " + op.OperationName + Environment.NewLine;
                specialized.Text += "------------------------------------------------------------------" + Environment.NewLine;
            }
        }
    }
}
