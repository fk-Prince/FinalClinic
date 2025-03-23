using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicSystem.PatientForm;
using MySql.Data.MySqlClient;

namespace ClinicSystem.Appointments
{
    public class ScheduleDatabase
    {
        private string driver = "server=localhost;username=root;pwd=root;database=db_clinic";

        public List<Appointment> getAppointments()
        {
            List<Appointment> list = new List<Appointment>();
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = @"SELECT patient_tbl.*, patientappointment_tbl.*, doctor_tbl.*, operation_tbl.*, clinichistory_tbl.DateAdmitted FROM patient_tbl
                                    LEFT JOIN patientappointment_tbl 
                                    ON patientappointment_tbl.patientId = patient_tbl.patientId
                                    LEFT JOIN doctor_operation_mm_tbl
                                    ON doctor_operation_mm_tbl.doctoroperationid = patientappointment_tbl.doctorOperationID
                                    LEFT JOIN doctor_tbl
                                    ON doctor_tbl.doctorId = doctor_operation_mm_tbl.doctorId
                                    LEFT JOIN operation_tbl
                                    ON operation_tbl.operationCode = doctor_operation_mm_tbl.OperationCode
                                    LEFT JOIN clinichistory_tbl
                                    ON clinichistory_tbl.patientid = patient_tbl.patientid
                                    WHERE patientappointment_tbl.AppointmentDetailNo IS NOT NULL";
                MySqlCommand command = new MySqlCommand(query, conn);
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
                            reader.IsDBNull(reader.GetOrdinal("contactnumber")) ? "N/A" : reader.GetString("contactnumber")
                        );

                    Doctor doctor = new Doctor(
                            reader.GetInt32("doctorid"),
                            reader.GetString("doctorfirstname"),
                            reader.GetString("doctormiddlename"),
                            reader.GetString("doctorlastname"),
                            reader.GetInt32("doctorage"),
                            reader.GetString("pin"),
                            reader.GetDateTime("datehired"),
                            reader.GetString("gender"),
                            reader.GetString("address")
                        );  

                    Operation operation = new Operation(
                             reader.GetString("OperationCode"),
                            reader.GetString("OperationName"),
                            reader.GetDateTime("dateAdded"),
                            reader.GetString("description"),
                            reader.GetDouble("price"),
                            reader.GetTimeSpan("duration")
                        );
                    int appointmentdetailno = reader.GetInt32("AppointmentDetailNo");

                    int roomno = reader.GetInt32("Roomno");
                    DateTime dateAdmitted = reader.GetDateTime("DateAdmitted");

                    Appointment app = new Appointment(
                        patient,
                        doctor,
                        operation,
                        reader.GetDateTime("DateSchedule"),
                        reader.GetTimeSpan("StartTime"),
                        reader.GetTimeSpan("EndTime"),
                        appointmentdetailno,
                        roomno,
                        dateAdmitted
                    );

                    list.Add(app);
                }
            } catch (MySqlException ex)
            {
                MessageBox.Show("error on get appointments() db" + ex.Message);
            }

            return list;
        }

        public List<Appointment> getAppointmentsbyDoctor(Doctor dr)
        {
            List<Appointment> list = new List<Appointment>();
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = @"SELECT * FROM patient_tbl
                            LEFT JOIN patientappointment_tbl 
                            ON patient_tbl.patientid = patientappointment_tbl.patientid
                            LEFT JOIN doctor_operation_mm_tbl
                            ON doctor_operation_mm_tbl.doctoroperationid = patientappointment_tbl.doctorOperationID
                            LEFT JOIN doctor_tbl
                            ON doctor_tbl.doctorId = doctor_operation_mm_tbl.doctorId
                            LEFT JOIN operation_tbl
                            ON operation_tbl.operationCode = doctor_operation_mm_tbl.OperationCode
                            LEFT JOIN clinichistory_tbl
                            ON clinichistory_tbl.patientid = patient_tbl.patientid
                            WHERE patient_tbl.patientid IS NOT NULL AND doctor_tbl.DOCTORID = @DOCTORID";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("DOCTORID",dr.DoctorID);
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
                    Doctor doctor = new Doctor(
                            reader.GetInt32("doctorid"),
                            reader.GetString("doctorfirstname"),
                            reader.GetString("doctormiddlename"),
                            reader.GetString("doctorlastname"),
                            reader.GetInt32("doctorage"),
                            reader.GetString("pin"),
                            reader.GetDateTime("datehired"),
                            reader.GetString("gender"),
                            reader.GetString("address")
                        );

                    Operation operation = new Operation(
                             reader.GetString("OperationCode"),
                            reader.GetString("OperationName"),
                            reader.GetDateTime("dateAdded"),
                            reader.GetString("description"),
                            reader.GetDouble("price"),
                            reader.GetTimeSpan("duration")
                        );

                    int roomno = reader.GetInt32("Roomno");
                    DateTime dateAdmitted = reader.GetDateTime("DateAdmitted");


                    Appointment app = new Appointment(
                        patient,
                        doctor,
                        operation, 
                        reader.GetDateTime("DateSchedule"), 
                        reader.GetTimeSpan("StartTime"), 
                        reader.GetTimeSpan("EndTime"),
                        reader.GetInt32("AppointmentDetailNo"),
                        roomno, 
                        dateAdmitted);
                    list.Add(app);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error on get appointments() db" + ex.Message);
            }

            return list;
        }


        public bool isAvailable(Appointment app)
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
                            "AND (patientappointment_tbl.StartTime < @EndTime AND patientappointment_tbl.EndTime > @StartTime) " +
                            "AND AppointmentDetailNo != @AppointmentDetailNo";
                MySqlCommand command = new MySqlCommand(query, conn);             
                command.Parameters.AddWithValue("@DoctorID", app.Doctor.DoctorID);
                command.Parameters.AddWithValue("@DateSchedule", app.DateSchedule.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@EndTime", app.EndTime);
                command.Parameters.AddWithValue("@StartTime", app.StartTime);
                command.Parameters.AddWithValue("@AppointmentDetailNo", app.AppointmentDetailNo);
                MySqlDataReader reader = command.ExecuteReader();

                return !reader.HasRows;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error on get isAvailable() db" + ex.Message);
            }
            return true;
        }

        public bool UpdateSchedule(Appointment app)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = @"UPDATE patientAppointment_tbl 
                                 SET `DateSchedule` = @DateSchedule, `StartTime` = @StartTime, `EndTime` = @EndTime 
                                WHERE AppointmentDetailNo = @AppointmentDetailNo";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@AppointmentDetailNo", app.AppointmentDetailNo);
                command.Parameters.AddWithValue("@DateSchedule", app.DateSchedule);
                command.Parameters.AddWithValue("@StartTime", app.StartTime);
                command.Parameters.AddWithValue("@EndTime", app.EndTime);
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
