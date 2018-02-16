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
        public static int direction;
        public static int speed;

        public static void Init()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(70, 20);

            GameOver = false;
            direction = 1;
            speed = 210;

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

        // serialize objects (Save function)
        // desiralize objects (Resume function)
    }
}
