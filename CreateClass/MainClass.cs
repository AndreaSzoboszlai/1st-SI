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
            DateTime parsedDate = DateTime.Parse("1991.06.16.");
            Person person1 = new Person("Andi", parsedDate, CreateClass.MainClass.Genders.female);

            Console.WriteLine(person1);

            Console.ReadLine();

            Room room = new Room(2);
            Employee employee1 = new Employee(100000, "cleaner", "Andi", DateTime.Now, CreateClass.MainClass.Genders.female, room);
            Console.WriteLine(employee1);
            Console.ReadLine();

            Employee Kovacs = new Employee( 1000, "Géza", "léhűtő", DateTime.Now, CreateClass.MainClass.Genders.male);
            Kovacs.RoomNum = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.RoomNum.RoomNum = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
            Console.ReadLine();
        }

        public enum Genders
        {
            male = 0,
            female = 1
        }
    }
}
