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
            int sum = 0;

            for (int i = 0; i < args.Length; i++)
                sum += int.Parse(args[i]);

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
