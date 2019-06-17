using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Room
    {
        public int RoomNum;
        public Room(int roomNum)
        {
            this.RoomNum = roomNum;
        }

        public int Number
        {
            get;
            internal set;
        }

        public override string ToString()
        {
            return "Room number: " + RoomNum;
        }
    }
}
