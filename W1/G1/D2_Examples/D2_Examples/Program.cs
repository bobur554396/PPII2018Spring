using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4, 5);
            r.findArea();
            r.findPer();

            Console.WriteLine(r);
            

            Console.ReadKey();
        }
    }
}
