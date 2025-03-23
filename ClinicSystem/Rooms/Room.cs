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
        private double price;

        public Room(int roomNo, string roomtype, double price)
        {
            this.roomNo = roomNo;
            this.roomtype = roomtype;
            this.price = price;
        }
        public Room(string roomtype, double price)
        {
            this.roomtype = roomtype;
            this.price = price;
        }

        public int RoomNo { get => roomNo; }
        public string Roomtype { get => roomtype; }
        public double Price { get => price;  }
    }
}
