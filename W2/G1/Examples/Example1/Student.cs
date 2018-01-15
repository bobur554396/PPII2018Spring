using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Student
    {
        private string name;
        private int age;

        public Student()
        {
            name = "Kbtu";
            age = 18;
        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        
        /*
        public string getName()
        {
            return name;
        }

        public void setName(string n)
        {
            name = n;
        }
        */

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if(value > 0)
                    age = value;
            }
        }


        public override string ToString()
        {
            return name + " " + age;
        }

    }
}
