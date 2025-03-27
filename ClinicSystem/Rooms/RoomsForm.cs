using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicSystem.Rooms
{
    public partial class RoomsForm : Form
    {
        private List<Room> roomList;
        private List<Room> roomType;
        private DatabaseRoom db = new DatabaseRoom();
        private Room selected;
        private bool isRoomPanel = false;
        public RoomsForm()
        {
            InitializeComponent();
            roomList = db.getRooms();
          
            addRoomPanel.Region = System.Drawing.Region.FromHrgn(dll.CreateRoundRectRgn(0, 0, addRoomPanel.Width, addRoomPanel.Height, 50, 50));
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(roomno.Text) || string.IsNullOrWhiteSpace(type.Text))
            {
                MessageBox.Show("Empty Field", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string roomtype = type.Text;
            int roomNumber;
            if (!int.TryParse(roomno.Text,out roomNumber))
            {
                MessageBox.Show("Room No can only be number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Room roomss in roomList)
            {
                if (roomss.RoomNo == roomNumber)
                {
                    MessageBox.Show("Try different RoomNo. this room already exist", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Room room = new Room(roomNumber, roomtype);
            db.insertRoom(room);
            MessageBox.Show("Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            roomno.Text = "";
            type.Text = "";
            roomList = db.getRooms();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timerout.Start();
            isRoomPanel = !isRoomPanel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isRoomPanel)
            {
                return;
            }
            isRoomPanel = !isRoomPanel;
            timerin.Start();
            flowLayoutPanel1.Visible = false;
        }
        private int x = -375;
        private void timerin_Tick(object sender, EventArgs e)
        {
            x += 20;
          
            if (x >= 375)
            {
                x = 375;
                timerin.Stop();
            }
            addRoomPanel.Location = new Point(x, 80);
        }

        private void timerout_Tick(object sender, EventArgs e)
        {
            x -= 20;
            addRoomPanel.Location = new Point(x, 80);
            if (x <= -375)
            {
                timerout.Stop();
                addRoomPanel.Visible = false;
                flowLayoutPanel1.Visible = true;
            }
        }
    }
}
