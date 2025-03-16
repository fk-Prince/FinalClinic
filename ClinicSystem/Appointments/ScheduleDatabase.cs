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

        public List<DoctorOperation> getAppointments()
        {
            List<DoctorOperation> list = new List<DoctorOperation>();
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = @"SELECT * FROM patient_tbl
                            LEFT JOIN patientoperationdetails_tbl 
                            ON patientoperationdetails_tbl.patientId = patient_tbl.patientid
                            LEFT JOIN patientappointment_tbl 
                            ON patientoperationdetails_tbl.patientOperationNo = patientappointment_tbl.patientOperationNo
                            LEFT JOIN doctor_operation_mm_tbl
                            ON doctor_operation_mm_tbl.doctoroperationid = patientappointment_tbl.doctorOperationID
                            LEFT JOIN doctor_tbl
                            ON doctor_tbl.doctorId = doctor_operation_mm_tbl.doctorId
                            LEFT JOIN operation_tbl
                            ON operation_tbl.operationCode = doctor_operation_mm_tbl.OperationCode
                            LEFT JOIN clinichistory_tbl
                            ON clinichistory_tbl.patientid = patient_tbl.patientid
                            WHERE patientoperationdetails_tbl.patientOperationNo IS NOT NULL";
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
                    Appointment schedule = new Appointment(
                        operation,
                        doctor,
                        reader.GetDateTime("DateSchedule"),
                        reader.GetTimeSpan("StartTime"),
                        reader.GetTimeSpan("EndTime"),
                        appointmentdetailno
                     );

                    int roomno = reader.GetInt32("Roomno");
                    DateTime dateAdmitted = reader.GetDateTime("DateAdmitted");


                    DoctorOperation docop = new DoctorOperation(schedule, roomno, patient, dateAdmitted);
                    list.Add(docop);
                }
            } catch (MySqlException ex)
            {
                MessageBox.Show("error on get appointments() db" + ex.Message);
            }

            return list;
        }

        public List<DoctorOperation> getAppointmentsbyDoctor(Doctor dr)
        {
            List<DoctorOperation> list = new List<DoctorOperation>();
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = @"SELECT * FROM patient_tbl
                            LEFT JOIN patientoperationdetails_tbl 
                            ON patientoperationdetails_tbl.patientId = patient_tbl.patientid
                            LEFT JOIN patientappointment_tbl 
                            ON patientoperationdetails_tbl.patientOperationNo = patientappointment_tbl.patientOperationNo
                            LEFT JOIN doctor_operation_mm_tbl
                            ON doctor_operation_mm_tbl.doctoroperationid = patientappointment_tbl.doctorOperationID
                            LEFT JOIN doctor_tbl
                            ON doctor_tbl.doctorId = doctor_operation_mm_tbl.doctorId
                            LEFT JOIN operation_tbl
                            ON operation_tbl.operationCode = doctor_operation_mm_tbl.OperationCode
                            LEFT JOIN clinichistory_tbl
                            ON clinichistory_tbl.patientid = patient_tbl.patientid
                            WHERE patientoperationdetails_tbl.patientOperationNo IS NOT NULL AND doctor_tbl.DOCTORID = @DOCTORID";
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
                    Appointment schedule = new Appointment(
                        operation,
                        doctor,
                        reader.GetDateTime("DateSchedule"),
                        reader.GetTimeSpan("StartTime"),
                        reader.GetTimeSpan("EndTime")
                     );

                    int roomno = reader.GetInt32("Roomno");
                    DateTime dateAdmitted = reader.GetDateTime("DateAdmitted");


                    DoctorOperation docop = new DoctorOperation(schedule, roomno, patient, dateAdmitted);
                    list.Add(docop);
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
                            "AND (patientappointment_tbl.StartTime < @EndTime OR patientappointment_tbl.EndTime > @StartTime) " +
                            "AND AppointmentDetailNo != @AppointmentDetailNo";
                MySqlCommand command = new MySqlCommand(query, conn);
                MessageBox.Show(app.DateSchedule.ToString("yyyy-MM-dd") + "    " + app.StartTime);
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
    }
}
