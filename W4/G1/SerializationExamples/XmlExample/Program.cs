using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlExample
{
    class Program
    {
        static void f1()
        {
            FileStream fs = new FileStream(@"data.xml", FileMode.Create, FileAccess.Write);

            XmlSerializer xs = new XmlSerializer(typeof(Student));
            Student s = new Student();
            try
            {
                xs.Serialize(fs, s);
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
            FileStream fs = new FileStream(@"data.xml", FileMode.Open, FileAccess.Read);

            XmlSerializer xs = new XmlSerializer(typeof(Student));
            try
            {
                Student s = xs.Deserialize(fs) as Student;
            
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
