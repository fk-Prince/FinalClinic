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
                MessageBox.Show("Error from getPatients() DB" + ex.Message);
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
                MessageBox.Show("Error from updateSchedule() DB" + ex.Message);
            }
            return false;
        }
    }
}
