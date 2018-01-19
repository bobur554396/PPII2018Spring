using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();

            //e1.setName("FIT");


            //e1.wage = -1;

            e1.Wage = -1;

            Console.WriteLine(e1);


            Console.ReadKey();
        }
    }
}
