using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Food
    {
        public Point location;
        public char sign;
        public ConsoleColor color;

        public Food()
        {
            color = ConsoleColor.Green;
            sign = '@';
            location = new Point(20, 10);
        }

        public void SetRandomPosition()
        {
            int x = new Random().Next(0, 70);
            int y = new Random().Next(0, 20);

            // TODO: check for collision with wall and snake

            location = new Point(x, y);
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(location.x, location.y);
            Console.Write(sign);
        }
    }
}
