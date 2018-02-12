using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFieldExample
{
    class Program
    {
        public void f1()
        {

        }
        static void Main(string[] args)
        {
            Class1 a1 = new Class1();

            //Program p = new Program();
            //p.f1();
            

            a1.increment();
            a1.increment();
            a1.increment();
            a1.increment();
            //a1.print();

            Class1 a2 = new Class1();
            a2.increment();
            //a2.print();

            Class2 b1 = new Class2();
            b1.increment();
            b1.increment();
            //b1.print();

            Class2 b2 = new Class2();
            b2.increment();
            //b2.print();

            Class2 b3 = new Class2();
            //b3.print();

            Class2 b4 = new Class2();
            b4.increment();
            //b4.print();


            Console.WriteLine(Class2.cnt);
            //a2.findArea();
            //Console.WriteLine(Class1.sum(2, 3));

            Console.ReadKey();
        }
    }
}
