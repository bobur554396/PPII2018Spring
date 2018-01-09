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
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += int.Parse(arr[i]);

            Console.WriteLine(sum);


            Console.ReadKey();
        }
    }
}
