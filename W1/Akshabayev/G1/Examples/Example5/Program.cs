using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    class Student
    {
        public string name;
        public int age;
        public float gpa;

        public Student()
        {
            name = "KBTU";
            age = 18;
            gpa = 4;
        }

        public Student(string n, int a, float g)
        {
            name = n;
            age = a;
            gpa = g;
        }

        public override string ToString()
        {
            return name + " " + age + " " + gpa;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.name = "FIT";
            Console.WriteLine(s);


            Student s2 = new Student("aaa", 17, 4);
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
