using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Program
    {


        static void MoveSnake()
        {
            while (!Game.GameOver)
            {
                switch (Game.direction)
                {
                    case 1:
                        Game.snake.Move(1, 0);
                        break;
                    case 2:
                        Game.snake.Move(-1, 0);
                        break;
                    case 3:
                        Game.snake.Move(0, 1);
                        break;
                    case 4:
                        Game.snake.Move(0, -1);
                        break;
                }
                Game.Draw();
                Thread.Sleep(Game.speed);
            }
        }



        static void Main(string[] args)
        {
            Game.Init();
            Thread t = new Thread(MoveSnake);
            t.Start();
            while (!Game.GameOver)
            {
                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        Game.direction = 4;
                        break;
                    case ConsoleKey.DownArrow:
                        Game.direction = 3;
                        break;
                    case ConsoleKey.LeftArrow:
                        Game.direction = 2;
                        break;
                    case ConsoleKey.RightArrow:
                        Game.direction = 1;
                        break;
                }
                
            }

            
        }
    }
}
