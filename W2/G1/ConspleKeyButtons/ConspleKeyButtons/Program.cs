using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConspleKeyButtons
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo btn = Console.ReadKey();

            while (btn.Key != ConsoleKey.Q)
            {
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("pressed Up arrow");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("pressed Down arrow");
                        break;
                }
                btn = Console.ReadKey();
            }
        }
    }
}
