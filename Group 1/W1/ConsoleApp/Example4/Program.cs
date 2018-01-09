using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            string[] arr = line.Split(' ');

            int sum = 0;
            foreach (string s in arr)
                sum += int.Parse(s);

            Console.WriteLine(sum);


            //int[] a = { 1, 2, 4, 5 };
            //int[] a = new int[4];

            char[] c = new char[10];

            string[] ar = new string[] { "asd", "qwe" };


            Console.ReadKey();

        }
    }
}
