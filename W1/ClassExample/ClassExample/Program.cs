using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Student
    {
        public string name;
        public int age;
        public float gpa;

        public Student()
        {
            name = "Arman";
            age = 18;
            gpa = 4;
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

            Console.WriteLine(s);

            Console.ReadKey();

        }
    }
}
