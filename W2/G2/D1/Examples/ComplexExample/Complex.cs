using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexExample
{
    class Complex
    {
        public int x, y;

        public Complex() { }
        public Complex(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.x = a.x + b.x;
            res.y = a.y + b.y;

            return res;
        }

        public override string ToString()
        {
            return x + " " + y;
        }
    }
}
