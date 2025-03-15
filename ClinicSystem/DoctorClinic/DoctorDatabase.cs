using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicSystem;
using ClinicSystem.PatientForm;
using MySql.Data.MySqlClient;

namespace DoctorClinic
{
    public class DoctorDatabase
    {
        private string driver = "server=localhost;username=root;pwd=root;database=db_clinic";

        public List<Appointment> getPatients(int doctorID)
        {
            List<Appointment> appointments = new List<Appointment>();
            try {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = @"SELECT * FROM patient_tbl
                        JOIN clinichistory_tbl ON patient_tbl.patientId = clinichistory_tbl.patientid
                        JOIN patientoperationdetails_tbl ON patient_tbl.patientid = patientoperationdetails_tbl.patientid
                        JOIN patientappointment_tbl ON patientappointment_tbl.patientOperationNo = patientoperationdetails_tbl.patientOperationNo
                        JOIN doctor_operation_mm_tbl ON doctor_operation_mm_tbl.doctorOperationID = patientappointment_tbl.doctorOperationID
                        JOIN operation_tbl ON doctor_operation_mm_tbl.OperationCode = operation_tbl.operationCode
                        WHERE doctor_operation_mm_tbl.DoctorId = @DoctorID";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("DoctorID", doctorID);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
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

                    int roomno = reader.GetInt32("RoomNo");
                    Operation operation = new Operation(
                           reader.GetString("OperationCode"),
                          reader.GetString("OperationName"),
                          reader.GetDateTime("dateAdded"),
                          reader.GetString("description"),
                          reader.GetDouble("price"),
                          reader.GetTimeSpan("duration")
                      );

                    DateTime date = reader.GetDateTime("DateSchedule");
                    TimeSpan startTime = reader.GetTimeSpan("StartTime");
                    TimeSpan endTime = reader.GetTimeSpan("EndTime");
                    string diagnosis = reader.IsDBNull(reader.GetOrdinal("diagnosis")) ? "" : reader.GetString("diagnosis");
                    int appointmentno = reader.GetInt32("appointmentDetailNo");
                    Appointment app = new Appointment(date, startTime, endTime, patient, operation, roomno, diagnosis, appointmentno);
                    appointments.Add(app);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("xd");
            }
            return appointments;
        }

        public bool updateSchedule(Appointment updatedSchedule)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = @"UPDATE patientAppointment_tbl 
                                 SET `Diagnosis` = @Diagnosis
                                WHERE AppointmentDetailNo = @AppointmentDetailNo";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Diagnosis", updatedSchedule.Diagnosis);
                command.Parameters.AddWithValue("@AppointmentDetailNo", updatedSchedule.AppointmentDetailNo);
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {

            }
            return false;
        }

        public bool isScheduleAvailable(Appointment schedule)
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
                             "AND (patientappointment_tbl.StartTime < @EndTime AND patientappointment_tbl.EndTime > @StartTime )";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@DoctorID", schedule.Doctor.DoctorID);
                command.Parameters.AddWithValue("@DateSchedule", schedule.DateSchedule.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@StartTime", schedule.StartTime);
                command.Parameters.AddWithValue("@EndTime", schedule.EndTime);
                command.Parameters.AddWithValue("@AppointmentDetailNo", schedule.AppointmentDetailNo);
                MySqlDataReader reader = command.ExecuteReader();

                return !reader.HasRows;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error from isScheduleAvailable DB" + ex.Message);
            }
            return true;
        }
        public bool isScheduleAvailable2(Appointment schedule)
        {
            try
            {
                //int op = getDoctorOperationId(schedule.Doctor, selectedOperation);
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "SELECT patientappointment_tbl.* " +
                             "FROM patientappointment_tbl " +
                             "JOIN doctor_operation_mm_tbl ON patientappointment_tbl.doctorOperationID = doctor_operation_mm_tbl.DoctorOperationId " +
                             "WHERE doctor_operation_mm_tbl.DoctorID = @DoctorID " +
                             "AND patientappointment_tbl.DateSchedule = @DateSchedule " +
                             "AND (patientappointment_tbl.StartTime < @EndTime AND patientappointment_tbl.EndTime > @StartTime ) " +
                             "AND patientappointment_tbl.appointmentdetailNo != @AppointmentDetailNo";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@DoctorID", schedule.Doctor.DoctorID);
                command.Parameters.AddWithValue("@DateSchedule", schedule.DateSchedule.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@StartTime", schedule.StartTime);
                command.Parameters.AddWithValue("@EndTime", schedule.EndTime);
                command.Parameters.AddWithValue("@AppointmentDetailNo", schedule.AppointmentDetailNo);
                MySqlDataReader reader = command.ExecuteReader();

                return !reader.HasRows;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error from isScheduleAvailable DB" + ex.Message);
            }
            return true;
        }
    }
}
