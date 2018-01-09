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
            name = "Kbtu";
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
            s.name = "FIT";


            Student s2 = new Student();
            Console.WriteLine(s2);



            Console.ReadKey();
        }
    }
}
