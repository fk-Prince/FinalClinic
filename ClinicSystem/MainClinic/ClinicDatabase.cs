using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicSystem.PatientForm;
using MySql.Data.MySqlClient;

namespace ClinicSystem.MainClinic
{
    public class ClinicDatabase
    {
        private string driver = "server=localhost;username=root;pwd=root;database=db_clinic";
        public ClinicDatabase()
        {
        }

        public int TotalPatientLastMonth()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "SELECT COUNT(*) as COUNT FROM patient_tbl";  
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader.GetInt32("COUNT");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error on TotalPatientLastMonth() db" + ex.Message);
            }
            return 0;
        }

        public List<int> getPatients()
        {
            List<int> list = new List<int>();
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT age FROM patient_tbl", conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader.GetInt32("age"));
                }
                conn.Close();
            } catch (MySqlException ex)
            {
                MessageBox.Show("Error on getPatients() db" + ex.Message);
            }
            return list;
        }

        public int getDoctor()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "SELECT COUNT(*) as COUNT FROM doctor_tbl";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader.GetInt32("COUNT");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error on getDoctor() db" + ex.Message);
            }
            return 0;
        }
    }
}