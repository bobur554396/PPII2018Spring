using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Wall
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;

        public Wall()
        {
            sign = '#';
            color = ConsoleColor.Magenta;
            body = new List<Point>();
            LoadLevel(1);
        }

        public void LoadLevel(int level)
        {
            string fileName = string.Format(@"Levels\level{0}.txt", level);
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            int row = 0;
            string line = "";
            while(row < 20)
            {
                line = sr.ReadLine();
                for(int col = 0; col < line.Length; col++)
                {
                    if (line[col] == '#')
                        body.Add(new Point(col, row));
                }
                row++;
            }
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
    }
}
