using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFieldExample
{
    class Class1
    {
        public int cnt = 0;

        public void increment()
        {
            cnt++;
        }

        public void print()
        {
            Console.WriteLine(cnt);
        }

        public static int sum(int a, int b)
        {
            return a + b;
        }

        public void findArea()
        {

        }
    }
}
