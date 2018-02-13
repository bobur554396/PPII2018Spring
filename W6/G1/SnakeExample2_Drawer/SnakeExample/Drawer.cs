using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Drawer
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;

        public Drawer(List<Point> b, char s, ConsoleColor c)
        {
            body = b;
            sign = s;
            color = c;
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }


    }
}
