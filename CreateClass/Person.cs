using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        string name;
        string birthday;
        CreateClass.MainClass.Genders gender;


        public Person(string name, string birthday, CreateClass.MainClass.Genders gender)
        {
            this.name = name;
            this.birthday = birthday;
            this.gender = gender;
        }

        public override string ToString()
        {
            return "Person: " + name + " " + birthday + " " + gender;
        }

    }
}
