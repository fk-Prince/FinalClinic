using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem.Rooms
{
    public class Room
    {
        private int roomNo;
        private string roomtype;

        public Room(int roomNo, string roomtype)
        {
            this.roomNo = roomNo;
            this.roomtype = roomtype;
        }


        public int RoomNo { get => roomNo; }
        public string Roomtype { get => roomtype; }
    }
}
