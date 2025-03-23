﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicSystem.Rooms
{
    public partial class RoomsForm : Form
    {
        private List<Room> roomList;
        private List<Room> roomType;
        private DatabaseRoom db = new DatabaseRoom();
        private Room selected;
        public RoomsForm()
        {
            InitializeComponent();
            roomList = db.getRooms();
            roomType = db.getRoomType();
            foreach (Room room in roomType)
            {    
               comboType.Items.Add(room.Roomtype);
            }
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboType.SelectedIndex == -1) return;

            string roomtype = comboType.SelectedItem.ToString();
            foreach (Room room in roomType)
            {
                if (roomtype.Equals(room.Roomtype, StringComparison.OrdinalIgnoreCase)) roomprice.Text = room.Price.ToString();
                selected = room;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(roomno.Text))
            {
                MessageBox.Show("Empty Roomno", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboType.SelectedIndex == -1)
            {
                MessageBox.Show("Select room type.", "RoomType", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            Room room = new Room(roomNumber, selected.Roomtype, selected.Price);
            db.insertRoom(room);
            MessageBox.Show("Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            roomno.Text = "";
            roomprice.Text = "";
            comboType.SelectedIndex = -1;
            roomList = db.getRooms();
            comboType.Items.Clear();
            foreach (Room roomdasd in roomType)
            {
                if (!comboType.Items.Contains(roomdasd.Roomtype))
                {
                    comboType.Items.Add(roomdasd.Roomtype);
                }
            }
        }
    }
}
