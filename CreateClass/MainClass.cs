using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Andi", "1991.06.16.", CreateClass.MainClass.Genders.female);

            Console.WriteLine(person1);

            Console.ReadLine();
        }

        public enum Genders
        {
            male = 0,
            female = 1
        }
    }
}
