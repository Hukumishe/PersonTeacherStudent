using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTeacherStudent
{
    abstract class Person
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        virtual public void Print()
        {
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Класс: " + Grade);
        }

        public static void RandomPerson()
        {
            Random rnd = new Random();
            List<Person> people = new List<Person>();
            int cnt = 1;

            while(cnt <= rnd.Next(1,100))
            {
                people[cnt].Name = string.Format("Person_{0}", rnd.Next(1, 100));
                people[cnt].Grade = rnd.Next(1, 8);
            }

            int check = rnd.Next(1, 100);
            Console.WriteLine(people[check].Name);
            Console.WriteLine(people[check].Grade);
        }

        public static void RandomTeacher()
        {
            Random rnd = new Random();
            List<Teacher> people = new List<Teacher>();
            int cnt = 1;

            while (cnt <= rnd.Next(1, 100))
            {
                people[cnt].Name = string.Format("Teacher_{0}", rnd.Next(1, 100));
                people[cnt].Grade = rnd.Next(1, 8);
            }

            int check = rnd.Next(1, 100);
            Console.WriteLine(people[check].Name);
            Console.WriteLine(people[check].Grade);
        }

        public static void RandomStudent()
        {
            Random rnd = new Random();
            List<Student> people = new List<Student>();
            int cnt = 1;

            while (cnt <= rnd.Next(1, 100))
            {
                people[cnt].Name = string.Format("Student_{0}", rnd.Next(1, 100));
                people[cnt].Grade = rnd.Next(1, 8);
            }

            int check = rnd.Next(1, 100);
            Console.WriteLine(people[check].Name);
            Console.WriteLine(people[check].Grade);
        }

        public override string ToString()
        {
            return "Это человек";
        }
    }
}
