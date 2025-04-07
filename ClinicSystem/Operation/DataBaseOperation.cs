using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ClinicSystem
{
    public class DataBaseOperation
    {
        private const string driver = "server=localhost;username=root;pwd=root;database=db_clinic";

        public List<Operation> getOperations()
        {
            List<Operation> operations = new List<Operation>();
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "SELECT * FROM operation_tbl";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    Operation operation = new Operation(
                        reader.GetString("operationcode"),
                        reader.GetString("operationname"),
                        reader.GetDateTime("dateadded"),
                        reader.GetString("description"),
                        reader.GetDouble("price"),
                        reader.GetTimeSpan("duration"),
                        reader.GetString("roomtype")
                    );
                    getDoctor(operation);
                    operations.Add(operation);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR FROM GETOPERATIONS() DB " + ex.Message);
            }
            return operations;
        }

        private void getDoctor(Operation operation)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "SELECT * FROM doctor_operation_mm_tbl " +
                    "LEFT JOIN doctor_tbl ON doctor_operation_mm_tbl.DoctorId = doctor_tbl.doctorId " +
                    "WHERE OperationCode = @OperationCode";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@OperationCode", operation.OperationCode);
                MySqlDataReader reader = command.ExecuteReader();
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
                        reader.GetString("doctorAddress"),
                            reader.GetString("doctorcontactnumber"));

                    operation.Doctor.Add(doctor);
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR FROM GETDOCTOR() DB " + ex.Message);
            }
        }
        public bool insert(int frontDeskId, Operation operation)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "INSERT INTO operation_tbl(operationcode, OperationName, dateadded, description, price, duration, roomtype) " +
                    "VALUES(@OperationCode, @OperationName, @DateAdded, @Description, @Price, @Duration, @roomtype)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OperationCode", operation.OperationCode);
                cmd.Parameters.AddWithValue("@OperationName", operation.OperationName);
                cmd.Parameters.AddWithValue("@DateAdded", operation.DateAdded);
                cmd.Parameters.AddWithValue("@Description", operation.Description);
                cmd.Parameters.AddWithValue("@Price", operation.Price);
                cmd.Parameters.AddWithValue("@Duration", operation.Duration);
                cmd.Parameters.AddWithValue("@roomtype", operation.OperationRoomType);
                cmd.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR FROM INSERT() DB " + ex.Message);
            }
            return false;
        }


        public List<Operation> getOperationByDoctor(int id)
        {
            List<Operation> operations = new List<Operation>();
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                string query = "SELECT doctor_operation_mm_tbl.OperationCode, Operation_tbl.* " +
                    "FROM doctor_operation_mm_tbl " +
                    "LEFT JOIN Operation_tbl " +
                    "ON Operation_tbl.OperationCode = doctor_operation_mm_tbl.OperationCode " +
                    "WHERE DOCTORID = @DoctorID;";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@DoctorID", id);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Operation operation = new Operation(
                       reader.GetString("operationcode"),
                       reader.GetString("operationName"),
                       reader.GetDateTime("dateadded"),
                       reader.GetString("description"),
                       reader.GetDouble("price"),
                       reader.GetTimeSpan("duration"),
                       reader.GetString("roomtype")
                   );
                    operations.Add(operation);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR FROM getOperationByDoctor() DB " + ex.Message);
            }

            return operations;
        }

        internal List<string> getAvailableRoomType()
        {
            List<string> roomTypes = new List<string>();
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM roomtype_tbl", conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    roomTypes.Add(reader.GetString("roomtype"));
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR FROM getAvailableRoomType() DB " + ex.Message);
            }
            return roomTypes;
        }
    }
}