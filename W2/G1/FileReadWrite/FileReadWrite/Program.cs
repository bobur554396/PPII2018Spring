using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadWrite
{
    class Program
    {


        static void f1()
        {
            FileStream fs = new FileStream(@"C:\test\file1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            Console.WriteLine(sr.ReadLine());

            sr.Close();
            fs.Close();
        }
        static void f2()
        {
            FileStream fs = new FileStream(@"C:\test\file1.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("asd");

            sw.Close();
            fs.Close();
        }


        static void Main(string[] args)
        {
            f2();


            Console.ReadKey();

        }
    }
}
