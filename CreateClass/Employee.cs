using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        private int Salary;
        private string Profession;
        public Room RoomNum;

        public Employee(int salary, string profession, string name, string birthday, MainClass.Genders gender, Room roomNum) : base(name, birthday, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
            this.RoomNum = roomNum;
        }

        public Employee(int salary, string profession, string name, string birthday, MainClass.Genders gender) : base(name, birthday, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
        }

        public Room Room
        {
            get;
            internal set;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }

        public override string ToString()
        {
            return base.ToString() + ", Salary: " + Salary + ", Profession: " + Profession + ", " + RoomNum;
        }
    }
}
