using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_Examples
{
    class Rectangle
    {
        public int width;
        public int height;
        public int area;
        public int per;
        
        public Rectangle()
        {
            width = 2;
            height = 3;
        }

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public Rectangle(int h)
        {
            width = 10;
            height = h;
        }

        public void findArea()
        {
            area = width * height;
        }

        public void findPer()
        {
            per = (width + height) * 2;
        }

        public override string ToString()
        {
            return width + "\n" + height + "\n" + area + "\n" + per;
        }
    }
}
