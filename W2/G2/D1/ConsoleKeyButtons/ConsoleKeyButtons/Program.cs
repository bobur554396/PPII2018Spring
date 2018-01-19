using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKeyButtons
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ConsoleKeyInfo btn = Console.ReadKey();

            while (btn.Key != ConsoleKey.Escape)
            {
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("clicked up arrow");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("clicked down arrow");
                        break;
                }
                /*
                if (btn.Key == ConsoleKey.UpArrow) { }
                else if (btn.Key == ConsoleKey.DownArrow) { }
                */
                btn = Console.ReadKey();
            }

            
        }
    }
}
