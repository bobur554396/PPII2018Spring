using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Employee
    {
        public string name;
        public float wage;

        public Employee()
        {
            name = "Em1";
            wage = 500;
        }

        public Employee(string name, float wage)
        {
            this.name = name;
            this.wage = wage;

            incWage();
        }

        private void incWage()
        {
            wage += 200;
        }

        public override string ToString()
        {
            return name + " " + wage;
        }

        
    }
}
