using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationExamples
{
    [Serializable]
    class Student
    {
        [NonSerialized]
        public string name;
        public int age;

        public Student()
        {
            name = "KBTU";
            age = 18;
        }

        public override string ToString()
        {
            return name + " " + age;
        }
    }
}
