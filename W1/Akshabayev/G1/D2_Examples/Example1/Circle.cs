using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Circle
    {
        public double radius;
        public double area;

        public Circle() {
            radius = 10;
        }

        public Circle(double radius)
        {
            this.radius = radius;
            findArea();
        }

        public void findArea()
        {
            area = Math.PI * radius * radius;
        }

        public double findArea2()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return "radius = " + radius + "\narea = " + area;
        }


    }
}
