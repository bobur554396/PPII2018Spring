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
            Employee e = new Employee();

            Employee e2 = new Employee("Employee10", 400);
            //e2.incWage();

            Console.WriteLine(e2);

            Console.ReadKey();
            
        }
    }
}
