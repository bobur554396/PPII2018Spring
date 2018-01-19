using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Employee
    {
        public string name;
        public float wage;

        public Employee()
        {
            name = "KBTU";
            wage = 100;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string n)
        {
            name = n;
        }

        public float Wage
        {
            get { return wage; }
            set
            {
                if(value > 0)
                    wage = value;
            }
        }


        public override string ToString()
        {
            return name + " " + wage;
        }
    }
}
