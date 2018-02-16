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

        static void hello()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine(i);
                i++;
                Thread.Sleep(100);
            }
            //Console.WriteLine("hello");
        }


        static void ex1()
        {
            Thread t1 = new Thread(hello);
            t1.Start();
            t1.Join();
        }


        static void hello2()
        {
            for (int i = 0; i < 3; i++)
                Console.WriteLine(Thread.CurrentThread.Name + ": " + i);
        }

        static void ex2()
        {
            Thread[] arr = new Thread[3];
            for(int i = 0; i < 3; i++)
            {
                arr[i] = new Thread(hello2);
                arr[i].Name = "Thread #" + i;
                arr[i].Start();

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main thread start");

            ex1();

            Console.WriteLine("main thread end");
            Console.ReadKey();
        }
    }
}
