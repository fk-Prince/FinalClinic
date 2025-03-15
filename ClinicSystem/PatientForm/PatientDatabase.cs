using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ClinicSystem.Appointments;
using ClinicSystem.PatientForm;
using MySql.Data.MySqlClient;

namespace ClinicSystem
{
    public class PatientDatabase
    {
        private string driver = "server=localhost;username=root;pwd=root;database=db_clinic";
        public List<string> getRoomNo()
        {
            List<string> roomNo = new List<string>();
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                MySqlCommand command = new MySqlCommand(
                    "SELECT RoomNo FROM Rooms_tbl WHERE Occupation != 'Occupied'",
                    conn
                );
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    roomNo.Add(reader["RoomNo"].ToString());
                }
                conn.Close();
                reader.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error from getRoomNo DB" + e.Message);
            }
            return roomNo;
        }
        public bool insertPatient(int staffId, Patient patient, string roomno)
        {
           try
           {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();

                string query = "INSERT INTO patient_tbl (patientfirstname, patientmiddlename, patientlastname, address, age, gender, birthdate, contactnumber) " +
                          "VALUES (@patientfirstname, @patientmiddlename, @patientlastname, @address, @age, @gender, @birthdate, @contactnumber); " +
                          "SELECT LAST_INSERT_ID();";

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
                object result = command.ExecuteScalar();
                int patientid = Convert.ToInt32(result);
                conn.Close();
                insertPatientStaff( patientid, staffId);
                setRoomOccupieed(roomno);
                insertHistory(patientid, roomno);
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO ON INSERTPATIENT() DB " + ex.Message);
            }

            return false;
        }
        private void insertHistory(int patientid, string roomno)
        {
           try
           {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "INSERT INTO clinichistory_tbl (patientid, dateAdmitted, roomno ) VALUES (@patientid, @dateAdmitted, @roomno )";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@roomno", roomno);
                command.Parameters.AddWithValue("@patientid", patientid);
                command.Parameters.AddWithValue("@dateAdmitted", DateTime.Now.ToString("yyyy-MM-dd"));
                command.ExecuteNonQuery();
                conn.Close();
            }
           catch(MySqlException ex)
           {

           }
        }
        private void insertPatientStaff(int patientid, int staffId)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "INSERT INTO staffpatient_mm_tbl ( StaffId, PatientId) VALUES (@StaffId, @PatientID)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@StaffId", staffId);
                command.Parameters.AddWithValue("@PatientID", patientid);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error from insertPatientStaff() DB" + e.Message);
            }
        }
        public List<Operation> getOperations()
        {
            List<Operation> operations = new List<Operation>();
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM Operation_Tbl", conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Operation operation = new Operation(
                        reader.GetString("OperationCode"),
                        reader.GetString("operationName"),
                        reader.GetDateTime("DateAdded"),
                        reader.GetString("Description"),
                        reader.GetDouble("Price"),
                        reader.GetTimeSpan("Duration")
                    );
                    operations.Add(operation);
                }
                conn.Close();
                reader.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error from getOperations DB" + e.Message);
            }
            return operations;
        }
        public List<Doctor> getDoctors(Operation operation)
        {
            List<Doctor> doctorList = new List<Doctor>();
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "SELECT *, doctor_tbl.* FROM doctor_operation_mm_tbl " +
                    "LEFT JOIN doctor_tbl " +
                    "ON doctor_operation_mm_tbl.DoctorID = doctor_tbl.DoctorID " +
                    "WHERE operationcode = @operationcode";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@operationcode", operation.OperationCode);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Doctor doctor = new Doctor(
                        reader.GetInt32("DoctorID"),
                        reader.GetString("doctorFirstName"),
                        reader.GetString("doctorMiddleName"),
                        reader.GetString("doctorLastName"),
                        reader.GetInt32("doctorAge"),
                        reader.GetString("Pin"),
                        reader.GetDateTime("DateHired"),
                        reader.GetString("Gender"),
                        reader.GetString("Address")
                     );
                    doctorList.Add(doctor);
                }
                conn.Close();
                reader.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error from getDoctors DB" + e.Message);
            }
            return doctorList;
        }
        public string getPatientOperationNo()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT PatientOperationNo FROM PatientOperationDetails_Tbl " +
                    "ORDER BY PatientOperationNo DESC LIMIT 1 ", conn);
                MySqlDataReader reader = command.ExecuteReader();
                int id = reader.Read() ? int.Parse(reader["PatientOperationNo"].ToString()) + 1 : 1;
                return id.ToString();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error from getLastOperationNo DB" + e.Message);
            }
            return "0";
        }
        public bool isScheduleAvailable( Appointment schedule)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "SELECT patientappointment_tbl.* " +
                             "FROM patientappointment_tbl " +
                             "JOIN doctor_operation_mm_tbl ON patientappointment_tbl.doctorOperationID = doctor_operation_mm_tbl.DoctorOperationId " +
                             "WHERE doctor_operation_mm_tbl.DoctorID = @DoctorID " +
                             "AND patientappointment_tbl.DateSchedule = @DateSchedule " +
                             "AND (patientappointment_tbl.StartTime < @EndTime OR patientappointment_tbl.EndTime > @StartTime)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@DoctorID", schedule.Doctor.DoctorID);
                command.Parameters.AddWithValue("@DateSchedule", schedule.DateSchedule.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@StartTime", schedule.StartTime);
                command.Parameters.AddWithValue("@EndTime", schedule.EndTime);
                MySqlDataReader reader = command.ExecuteReader();

                return !reader.HasRows;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error from isScheduleAvailable DB" + ex.Message);
            }
            return true;
        }
        public List<Patient> getPatients()
        {
            List<Patient> patients = new List<Patient>();
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM patient_tbl",conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Patient patient = new Patient(
                            reader.GetInt32("patientid"),
                            reader.GetString("patientfirstname"),
                            reader.GetString("patientmiddlename"),
                            reader.GetString("patientlastname"),
                            reader.GetString("address"),
                            reader.GetInt32("age"),
                            reader.GetString("gender"),
                            reader.GetDateTime("birthdate"),
                            reader.IsDBNull(reader.GetOrdinal("contactnumber")) ? "Contact number not provided" : reader.GetString("contactnumber")
                        );
                    patients.Add(patient);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error from getPatients() db " + ex.Message);
            }
            return patients;
        }
        public bool AddAppointment(Patient patient, List<DoctorOperation> docOp, double bill)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "INSERT INTO patientoperationdetails_tbl (patientId, PatientBill ) VALUES (@patientId, @PatientBill); " +
                          "SELECT LAST_INSERT_ID();";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@patientId", patient.Patientid);
                command.Parameters.AddWithValue("@PatientBill", bill);
                object result = command.ExecuteScalar();
                int patientoperationNo = Convert.ToInt32(result);
                conn.Close();

                insertAppointment(patientoperationNo, docOp);
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error on addApoinment() db " + ex.Message);
            }
            return false;
        }
        private void insertAppointment(int patientoperationNo, List<DoctorOperation> docOp)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();

                foreach (DoctorOperation op in docOp)
                {
                    
                    int doctoroperationId = getDoctorOperationId(op.Doctor, op.Operation);

                    string query = "INSERT INTO patientappointment_tbl (patientOperationNo, doctoroperationID, dateSchedule, StartTime, EndTime) VALUES (@patientOperationNo, @doctoroperationID, @dateSchedule, @StartTime, @EndTime)";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@patientOperationNo", patientoperationNo);
                    command.Parameters.AddWithValue("@doctoroperationID", doctoroperationId);
                    command.Parameters.AddWithValue("@dateSchedule", op.Schedule.DateSchedule);
                    command.Parameters.AddWithValue("@StartTime", op.Schedule.StartTime);
                    command.Parameters.AddWithValue("@EndTime", op.Schedule.EndTime);



                    command.ExecuteNonQuery();

                  
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error on insertAppointment() db " + ex.Message);
            }
        }
        private int getDoctorOperationId(Doctor doctor, Operation operation)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "SELECT doctorOperationID FROM doctor_operation_mm_tbl WHERE DoctorID = @DoctorID AND OperationCode = @OperationCode";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@DoctorID", doctor.DoctorID);
                command.Parameters.AddWithValue("@OperationCode", operation.OperationCode);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32("doctorOperationId");
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error on getDoctorOperationId() db " + ex.Message);
            }

            return -1;
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
        public void setRoomOccupieed(string roomno)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "UPDATE rooms_tbl SET `Occupation` = 'Occupied' WHERE roomno = @roomno";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@roomno", roomno);
                command.ExecuteNonQuery();
                conn.Close();
            }catch (MySqlException ex)
            {
                MessageBox.Show("Error on setRoomOccupied() db" + ex.Message);
            }
        }
    }
}