using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person
    {
        private int salary;
        private string profession;

        public Employee(int salary, string profession, string name, string birthday, MainClass.Genders gender) : base(name, birthday, gender)
        {
            this.salary = salary;
            this.profession = profession;
        }

        public override string ToString()
        {
            return base.ToString() + "Salary: " + salary + " Profession: " + profession;
        }
    }
}
