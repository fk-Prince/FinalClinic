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
        public List<Room> getRoomNo()
        {
            List<Room> rooms = new List<Room>();
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                MySqlCommand command = new MySqlCommand( "SELECT * FROM Rooms_tbl", conn );
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Room room = new Room(reader.GetInt32("RoomNo"), reader["Roomtype"].ToString());
                    rooms.Add(room);
                }
                conn.Close();
                reader.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error from getRoomNo DB" + e.Message);
            }
            return rooms;
        }
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
                string query = "INSERT INTO clinichistory_tbl (patientid, visitDate, TotalBill) VALUES (@patientid, @visitDate, @TotalBill)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@patientid", patientid);
                command.Parameters.AddWithValue("@visitDate", DateTime.Now.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@TotalBill", "0");
                command.ExecuteNonQuery();
                conn.Close();
            }
           catch(MySqlException ex)
           {
                MessageBox.Show("Error on insertHistory() db" + ex.Message);
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
        public string getAppointmentDetail()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT AppointmentDetailNo FROM patientappointment_tbl " +
                    "ORDER BY AppointmentDetailNo DESC LIMIT 1 ", conn);
                MySqlDataReader reader = command.ExecuteReader();
                int id = reader.Read() ? int.Parse(reader["AppointmentDetailNo"].ToString()) + 1 : 1;
                return id.ToString();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error from getAppointmentDetail DB" + e.Message);
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
        public bool AddAppointment(Patient patient, List<Appointment> ap)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
              
                foreach (Appointment op in ap)
                {

                    int doctoroperationId = getDoctorOperationId(op.Doctor, op.Operation);

                    string query = "INSERT INTO patientappointment_tbl (doctoroperationID, patientid, dateSchedule, StartTime, EndTime, bill, roomno) " +
                               "VALUES " +
                               "(@doctoroperationID, @patientid, @dateSchedule, @StartTime, @EndTime, @bill, @roomno)";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@patientid",patient.Patientid);
                    command.Parameters.AddWithValue("@doctoroperationID", doctoroperationId);
                    command.Parameters.AddWithValue("@dateSchedule", op.DateSchedule);
                    command.Parameters.AddWithValue("@StartTime", op.StartTime);
                    command.Parameters.AddWithValue("@EndTime", op.EndTime);
                    command.Parameters.AddWithValue("@bill", op.Bill.ToString("F2"));
                    command.Parameters.AddWithValue("@roomno", op.RoomNo);
                    command.ExecuteNonQuery();
                }
                insertHistoryBill(ap.Sum(a => a.Bill),patient.Patientid);
                conn.Close();

              
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error on addApoinment() db " + ex.Message);
            }
            return false;
        }

        private void insertHistoryBill(double totalbill,int patientid)
        {
            try
            {

                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query1 = @"UPDATE clinichistory_tbl 
                            SET TotalBill = TotalBill + @NewBill 
                            WHERE PatientID = @PatientID";
                MySqlCommand command1 = new MySqlCommand(query1, conn);
                command1.Parameters.AddWithValue("@NewBill", totalbill);
                command1.Parameters.AddWithValue("@PatientID", patientid);
                int rowsAffected = command1.ExecuteNonQuery();
                conn.Close();
            }catch (MySqlException ex)
            {
                MessageBox.Show("error on insertHistoryBill() db " + ex.Message);
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

        internal bool isRoomAvailable(int roomno, DateTime selectedDate, TimeSpan startTime, TimeSpan endTime)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "SELECT patientappointment_tbl.* " +
                             "FROM patientappointment_tbl " +
                             "JOIN doctor_operation_mm_tbl ON patientappointment_tbl.doctorOperationID = doctor_operation_mm_tbl.DoctorOperationId " +
                             "WHERE Roomno = @Roomno " +
                             "AND patientappointment_tbl.DateSchedule = @DateSchedule " +
                             "AND (patientappointment_tbl.StartTime < @EndTime OR patientappointment_tbl.EndTime > @StartTime)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Roomno", roomno);
                command.Parameters.AddWithValue("@DateSchedule", selectedDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@StartTime", startTime);
                command.Parameters.AddWithValue("@EndTime", endTime);
                MySqlDataReader reader = command.ExecuteReader();
                return !reader.HasRows;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR ON patientid() DB" + ex.Message);
            }
            return false;
        }
    }
}