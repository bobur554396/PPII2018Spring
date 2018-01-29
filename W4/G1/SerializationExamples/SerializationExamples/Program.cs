using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationExamples
{
    class Program
    {

        static void f1()
        {
            FileStream fs = new FileStream(@"dat2.ser", FileMode.Create, FileAccess.Write);

            Student s = new Student();
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                bf.Serialize(fs, s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }

            Console.WriteLine("done");
        }

        static void f2()
        {
            FileStream fs = new FileStream(@"dat2.ser", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                Student s = bf.Deserialize(fs) as Student;

                Console.WriteLine(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        static void Main(string[] args)
        {
            f2();
            Console.ReadKey();
        }
    }
}
