using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            string[] arr = line.Split(' ');
            int prod = 1;
            for (int i = 0; i < arr.Length; i++)
                prod = prod * int.Parse(arr[i]);


            Console.WriteLine(prod);

            Console.ReadKey();
        }
    }
}
