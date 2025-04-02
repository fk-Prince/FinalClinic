using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClinicSystem.Rooms
{
    public class DatabaseRoom
    {
        private string driver = "server=localhost;username=root;pwd=root;database=db_clinic";
        public List<Room> getRooms()
        {
            List<Room> roomList = new List<Room>(); 
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();

                string query = "SELECT * FROM Rooms_tbl ";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Room room = new Room(reader.GetInt32("roomno"), reader.GetString("roomtype"));
                    roomList.Add(room);
                }
                conn.Close();

            }catch (MySqlException ex)
            {
                MessageBox.Show("Error on getRooms() DB" + ex.Message);
            }
            return roomList; 
        }

        public void insertRoom(Room room)
        {
           try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();

                string query = "INSERT INTO rooms_tbl (Roomno, RoomType ) VALUES (@RoomNo, @RoomType)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@RoomNo", room.RoomNo);
                command.Parameters.AddWithValue("@RoomType", room.Roomtype);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error on insertRoom() db" + ex.Message);
            }
        }

        internal List<string> getRoomsType()
        {
            List<string> roomType = new List<string>();
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM roomtype_tbl", conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    roomType.Add(reader.GetString("roomtype"));
                }
                conn.Close();
            }catch (MySqlException ex)
            {
                MessageBox.Show("Error on getRoomsType() db" + ex.Message);
            }
            return roomType;
        }
    }
}
