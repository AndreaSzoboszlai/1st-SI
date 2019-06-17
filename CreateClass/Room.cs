using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Room
    {
        private int roomNum;
        public Room(int roomNum)
        {
            this.roomNum = roomNum;
        }

        public override string ToString()
        {
            return "Room number: " + roomNum;
        }
    }
}
