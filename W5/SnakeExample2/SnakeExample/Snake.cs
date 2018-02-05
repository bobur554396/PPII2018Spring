using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Snake
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;

        public Snake()
        {
            sign = 'o';
            color = ConsoleColor.Yellow;
            body = new List<Point>();

            body.Add(new Point(10, 10));
            body.Add(new Point(11, 10));
            body.Add(new Point(12, 10));
        }

        public void Move(int dx, int dy)
        {
            Point lastPoint = body[body.Count - 1];
            Console.SetCursorPosition(lastPoint.x, lastPoint.y);
            Console.Write(' ');
            for(int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x = body[0].x + dx;
            body[0].y = body[0].y + dy;

            // collision with wall
            // collision with itself (snake)
            // load new level if ...
        }

        public bool CanEat(Food food)
        {
            if(food.location.x == body[0].x && 
                food.location.y == body[0].y)
            {
                body.Add(food.location);
                return true;
            }
            return false;
        }

        public void Draw()
        {
            int i = 0;
            foreach(Point p in body)
            {
                if (i == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = color;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                i++;
            }
        }
    }
}
