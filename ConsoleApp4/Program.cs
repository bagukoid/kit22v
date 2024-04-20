using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Student
    {
        public string Surname;
        public string Group;
        public int PhysicsScore;
        public int InformScore;
        public int HistoryScore;

        public Student(string sn, string grp, int ph, int inf, int hst)
        {
            Surname = sn;
            Group = grp;
            PhysicsScore = ph;
            InformScore = inf;
            HistoryScore = hst;
        }

        public string Table()
        {
            return $"{Surname}\t{Group}\t{PhysicsScore}\t{InformScore}\t{HistoryScore}";
        }

        public static string Header()
        {
            return "Surname\tGroup\tPhysics\tInform\tHistory";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Student st1 = new Student("Petrov", "3b", 5, 4, 3);
            //Student st2 = new Student("Ivanov", "2a", 5, 5, 5);

            List<Student> students = new List<Student>();
            students.Add(new Student("Petrov", "3b", 5, 4, 3));
            students.Add(new Student("Ivanov", "2a", 5, 5, 5));
            students.Add(new Student("Sidorov", "3c", 5, 4, 4));

            Console.WriteLine(Student.Header());
            foreach (Student s in students) Console.WriteLine(s.Table());
            //Console.WriteLine(st1.Table());
            //Console.WriteLine(st2.Table());

            Console.ReadKey();
        }
    }
}
