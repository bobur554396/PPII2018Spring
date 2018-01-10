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
            
            double r = double.Parse(Console.ReadLine());

            Circle c = new Circle(r);
            //c.findArea();

            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
