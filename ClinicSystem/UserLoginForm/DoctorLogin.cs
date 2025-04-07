using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClinicSystem.UserLoginForm
{
    public partial class DoctorLogin : Form
    {
        private static DoctorLogin instance;

        public DoctorLogin()
        {
            InitializeComponent();
            SetPlaceholder(DoctorID, "Doctor ID...");
            SetPlaceholder(PIN, "PIN...");
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        private const int EM_SETCUEBANNER = 0x1501;

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, placeholder);
        }

        public static DoctorLogin GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new DoctorLogin();
            }
            else
            {
                instance.Hide();
                instance = null;
                GetInstance();
            }
            return instance;
        }

        bool x = true;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (x)
            {
                panel1.Focus();
                x = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string doctorid = DoctorID.Text.Trim();
            string pin = PIN.Text.Trim();
            //LoginUserForm log = LoginUserForm.getInstance();
            //log.Hide();
            //this.Hide();
            //Doctor drs = new Doctor(1, "Prince", "dfgdfgdf", "Sestoso", 22, "0977", DateTime.Now, "Male", "Roxas");
            //DoctorClinics doc = new DoctorClinics(drs);
            //doc.Show();
            //return;
            try
            {
                if (string.IsNullOrWhiteSpace(doctorid) || string.IsNullOrWhiteSpace(pin))
                {
                    MessageBox.Show(
                        "Empty space, provide credentials",
                        "Incomplete Credentials",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
                string driver = "server=localhost;username=root;password=root;database=db_clinic";
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();

                string query = "SELECT * FROM doctor_tbl WHERE PIN = @PIN AND DOCTORID = @DOCTORID";
                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@DOCTORID", doctorid);
                command.Parameters.AddWithValue("@PIN", pin);

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows == false)
                {
                    MessageBox.Show(
                        "Wrong Doctor ID or PIN",
                        "Incorrect Credentials",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
                while (reader.Read())
                {
                    Doctor doctor = new Doctor(
                        reader.GetInt32("doctorid"),
                        reader.GetString("doctorfirstname"),
                        reader.GetString("doctormiddlename"),
                        reader.GetString("doctorlastname"),
                        reader.GetInt32("doctorage"),
                        reader.GetString("pin"),
                        reader.GetDateTime("doctordatehired"),
                        reader.GetString("doctorgender"),
                        reader.GetString("doctoraddress"),
                            reader.GetString("doctorcontactnumber")
                    );
                    MessagePromp.MainShowMessage(this, "Successfully Login", MessageBoxIcon.Information);
                    LoginUserForm log = LoginUserForm.getInstance();
                    log.Hide();
                    this.Hide();
                    DoctorClinics doc = new DoctorClinics(doctor);
                    doc.Show();
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
