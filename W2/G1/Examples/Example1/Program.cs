using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s2 = new Student("FIT", 18);

            //s2.setName("new Student name");


            Console.WriteLine(s2);

            Console.ReadKey();
        }
    }
}
