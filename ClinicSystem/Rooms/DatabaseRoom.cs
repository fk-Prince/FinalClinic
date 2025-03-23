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

                string query = "SELECT Rooms_tbl.Roomno, Rooms_tbl.roomtype, roomtype_tbl.roomprice  FROM Rooms_tbl LEFT JOIN roomtype_tbl on rooms_tbl.roomtype = roomtype_tbl.roomtype";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Room room = new Room(reader.GetInt32("roomno"), reader.GetString("roomtype"), reader.GetDouble("roomprice"));
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

        public List<Room> getRoomType()
        {
            List<Room> roomtype = new List<Room>();
            try
            {
                MySqlConnection conn = new MySqlConnection(driver);
                conn.Open();

                string query = "SELECT * FROM Roomtype_tbl";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Room room = new Room(reader.GetString("roomtype"), reader.GetDouble("roomprice"));
                    roomtype.Add(room);
                }
                conn.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error on getRoomType() DB" + ex.Message);
            }
            return roomtype;
        }
    }
}
