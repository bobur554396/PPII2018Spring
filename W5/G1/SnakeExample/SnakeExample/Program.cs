using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(70, 20);
            Snake snake = new Snake();
            Food food = new Food();
            Wall wall = new Wall();

            
            
            int cnt = 0;

            while (true)
            {
                Console.Clear();
                snake.Draw();
                food.Draw();
                wall.Draw();

                if (cnt % 3 == 0)
                {
                    food.SetRandomPosition();
                }

                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        snake.Move(0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        snake.Move(0, 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        snake.Move(-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        snake.Move(1, 0);
                        break;
                }
                cnt++;
            }
            

        }
    }
}
