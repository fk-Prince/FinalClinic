﻿using System;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

using System.Windows.Forms;
using ClinicSystem.UserLoginForm;

namespace ClinicSystem
{
    public partial class LoginUserForm : Form
    {
        private static LoginUserForm instance;
        public LoginUserForm()
        {
            InitializeComponent();
            SetPlaceholder(Username, "Username...");
            SetPlaceholder(Password, "Password...");
            instance = this;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        private const int EM_SETCUEBANNER = 0x1501;


        public static LoginUserForm getInstance()
        {
            return instance;
        }
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, placeholder);
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = Username.Text.Trim();
            string password = Password.Text.Trim();


            try
            {
                if (string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrWhiteSpace(Password.Text) || Username.Text == "User Name" || Password.Text == "Password")
                {
                    MessageBox.Show("Empty space, provide credentials", "Incomplete Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string driver = "server=localhost;username=root;password=root;database=db_clinic";
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();

                string query = "SELECT Username, Password, StaffId FROM staff_tbl WHERE USERNAME = @USERNAME AND PASSWORD = @PASSWORD";
                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@USERNAME", username);
                command.Parameters.AddWithValue("@PASSWORD", password);

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows == false)
                {
                    MessageBox.Show("Wrong Username or Password", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                while (reader.Read())
                {
                    Staff staff = new Staff(int.Parse(reader["StaffID"].ToString()), reader["Username"].ToString(), reader["Password"].ToString());
                    MessageBox.Show("Successfully Login", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ClinicSystem clinicSystem = new ClinicSystem(staff);
                    clinicSystem.Show();
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void doctorB_Click(object sender, EventArgs e)
        {
            DoctorLogin docl = DoctorLogin.GetInstance();
            docl.Show(); 
        }

      

        private bool initialFocuse = true;

        private void s(object sender, PaintEventArgs e)
        {
            if (initialFocuse)
            {
                v.Focus();
                initialFocuse = false;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();

            }  
         }

        private void button1_Click(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = !Password.UseSystemPasswordChar;
            passwordToggle.Image = Password.UseSystemPasswordChar ? Properties.Resources.shows : Properties.Resources.hide;
            SetPlaceholder(Username, "Username...");
            SetPlaceholder(Password, "Password...");
        }
    }
}
        
    
