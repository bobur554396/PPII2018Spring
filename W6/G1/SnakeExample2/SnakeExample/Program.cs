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
            Game.Init();

            
            while (!Game.GameOver)
            {
                //Console.Clear();
                Game.snake.Draw();
                Game.food.Draw();
                Game.wall.Draw();

                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        Game.snake.Move(0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        Game.snake.Move(0, 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        Game.snake.Move(-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        Game.snake.Move(1, 0);
                        break;
                }


                if (Game.snake.body[0].x < 0)
                    Game.snake.body[0].x = 69;
                if (Game.snake.body[0].x > 69)
                    Game.snake.body[0].x = 0;
                if (Game.snake.body[0].y < 0)
                    Game.snake.body[0].y = 19;
                if (Game.snake.body[0].y > 19)
                    Game.snake.body[0].y = 0;



                if (Game.snake.CanEat())
                {
                    Game.food.SetRandomPosition();
                }
            }
            

        }
    }
}
