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
        public Room RoomNum { get; set; }

        public Employee(int salary, string profession, string name, DateTime birthday, MainClass.Genders gender, Room roomNum) : base(name, birthday, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
            this.RoomNum = roomNum;
        }

        public Employee(int salary, string profession, string name, DateTime birthday, MainClass.Genders gender) : base(name, birthday, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.RoomNum = new Room(RoomNum.RoomNum);
            return newEmployee;
        }

        public override string ToString()
        {
            return base.ToString() + ", Salary: " + Salary + ", Profession: " + Profession + ", " + RoomNum;
        }
    }
}
