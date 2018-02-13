using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Game
    {
        public static Snake snake;
        public static Food food;
        public static Wall wall;
        public static bool GameOver;

        public static void Init()
        {
            GameOver = false;
            Console.CursorVisible = false;
            Console.SetWindowSize(70, 20);

            snake = new Snake();
            food = new Food();
            wall = new Wall();
        }

        public static void Draw()
        {
            //Console.Clear();
            snake.Draw();
            food.Draw();
            wall.Draw();
        }
    }
}
