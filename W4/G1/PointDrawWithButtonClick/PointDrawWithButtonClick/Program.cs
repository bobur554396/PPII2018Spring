using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointDrawWithButtonClick
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int x = 0, y = 0;

            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write('o');

                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
