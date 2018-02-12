using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFieldExample
{
    class Class2
    {
        public static int cnt = 0;

        public void increment()
        {
            cnt++;
        }

        public void print()
        {
            Console.WriteLine(cnt);
        }

    }
}
