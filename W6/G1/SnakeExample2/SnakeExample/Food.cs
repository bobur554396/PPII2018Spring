using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Food: Drawer
    {

        public Food()
        {
            sign = '@';
            color = ConsoleColor.Green;
            SetRandomPosition();
        }

        public void SetRandomPosition()
        {
            int x = new Random().Next(0, 70);
            int y = new Random().Next(0, 20);

            // TODO: is x and y on the wall?
            // TODO: is x and y on the snake?

            location = new Point(x, y);
        }
    }
}
