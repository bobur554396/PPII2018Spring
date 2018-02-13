using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExample
{
    class Program
    {
        static void test2()
        {
            Thread t1 = new Thread(hello);
            t1.Start();
            t1.Join();
        }

        public static void hello()
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "=" + i);
                i++;
            }
        }

        static void test()
        {
            Thread[] tt = new Thread[3];
            for(int i = 0; i < 3; i++)
            {
                tt[i] = new Thread(hello);
                tt[i].Name = "Thread" + i;
                tt[i].Start();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main thread start");

            test();

            Console.WriteLine("Main thread end");
            Console.ReadKey();
        }
    }
}
