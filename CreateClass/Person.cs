using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        string Name;
        DateTime Birthday;
        CreateClass.MainClass.Genders Gender;


        public Person(string name, DateTime birthday, CreateClass.MainClass.Genders gender)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return "Person: " + Name + " " + Birthday + " " + Gender;
        }

    }
}
