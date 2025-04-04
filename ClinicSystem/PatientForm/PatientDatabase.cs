using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ClinicSystem.Appointments;
using ClinicSystem.PatientForm;
using ClinicSystem.Rooms;
using MySql.Data.MySqlClient;

namespace ClinicSystem
{
    public class PatientDatabase
    {
        private string driver = "server=localhost;username=root;pwd=root;database=db_clinic";
        public bool insertPatient(int staffId, Patient patient)
        {
           try
           {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();

                string query = "INSERT INTO patient_tbl (patientfirstname, patientmiddlename, patientlastname, address, age, gender, birthdate, contactnumber) " +
                          "VALUES (@patientfirstname, @patientmiddlename, @patientlastname, @address, @age, @gender, @birthdate, @contactnumber)";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@patientfirstname", patient.Firstname);
                command.Parameters.AddWithValue("@patientmiddlename", patient.Middlename);
                command.Parameters.AddWithValue("@patientlastname", patient.Lastname);
                command.Parameters.AddWithValue("@address", patient.Address);
                command.Parameters.AddWithValue("@age", patient.Age);
                command.Parameters.AddWithValue("@gender", patient.Gender);
                command.Parameters.AddWithValue("@birthdate", patient.Birthdate.ToString("yyyy-MM-dd"));
                if (!string.IsNullOrEmpty(patient.ContactNumber))
                {
                    command.Parameters.AddWithValue("@contactnumber", patient.ContactNumber);
                }
                else
                {     
                    command.Parameters.AddWithValue("@contactnumber", DBNull.Value);
                }
                command.ExecuteNonQuery();
                conn.Close();
                insertHistory(patient.Patientid);
                insertStaffPatient(patient.Patientid, staffId);
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO ON INSERTPATIENT() DB " + ex.Message);
            }

            return false;
        }

        private void insertStaffPatient(int patientid, int staffId)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "INSERT INTO patient_staff_tbl (staffid, patientid) VALUES (@staffid, @patientid)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@staffid", staffId);
                command.Parameters.AddWithValue("@patientid", patientid);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error on insertStaffPatient() db" + ex.Message);
            }
        }

        private void insertHistory(int patientid)
        {
           try
           {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "INSERT INTO clinichistory_tbl (patientid, visitDate, recentlyVisitDate) VALUES (@patientid, @visitDate, @recentlyVisitDate)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@patientid", patientid);
                command.Parameters.AddWithValue("@visitDate", DateTime.Now.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@recentlyVisitDate", DateTime.Now.ToString("yyyy-MM-dd"));
                command.ExecuteNonQuery();
                conn.Close();
            }
           catch(MySqlException ex)
           {
                MessageBox.Show("Error on insertHistory() db" + ex.Message);
            }
        }

        public int getPatientId()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "SELECT patientId FROM patient_tbl ORDER BY patientId DESC LIMIT 1";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                return reader.Read() ? int.Parse(reader["patientId"].ToString()) + 1 : 1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR ON patientid() DB" + ex.Message);
            }
            return 1;
        }

        public int isPatientExist(Patient patient)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "SELECT patientid FROM patient_tbl WHERE patientfirstname = @patientfirstname AND patientmiddlename = @patientmiddlename AND patientlastname = @patientlastname";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@patientfirstname", patient.Firstname);
                command.Parameters.AddWithValue("@patientmiddlename", patient.Middlename);
                command.Parameters.AddWithValue("@patientlastname", patient.Lastname);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    return reader.GetInt32("patientid");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR ON isPatientExist() DB" + ex.Message);
            }
            return -1;
        }
    }
}