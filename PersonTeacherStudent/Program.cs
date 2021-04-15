using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTeacherStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Teacher teacher = new Teacher();

            teacher.Name = string.Format("Teacher_{0}", rnd.Next(1,20));
            teacher.Grade = rnd.Next(1, 6);

            Console.WriteLine("Хотите добавить студентов для преподавателя?\n1. Да\n2. Нет");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Сколько студентов вы хотите добавить?");
                        int StudNum = int.Parse(Console.ReadLine());
                        int cnt = 1;

                        while(cnt <= StudNum)
                        {
                            Student student = new Student();
                            student.Grade = teacher.Grade;
                            student.Name = string.Format("Student_{0}", rnd.Next(1, 20));
                            teacher.students.Add(student);
                            cnt++;
                        }
                    }
                    break;

                case 2:
                    break;
                default:
                    break;
            }

            foreach (Student item in teacher.students)
            {
                item.Print();
            }

            Person.RandomPerson();
            Person.RandomStudent();
            Person.RandomTeacher();
        }
    }
}
