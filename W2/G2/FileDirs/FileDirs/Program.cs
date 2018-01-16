using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirs
{
    class Program
    {

        static void f1()
        {
            FileInfo f = new FileInfo(@"C:\test\file1.txt");
            Console.WriteLine(f.Name);
            Console.WriteLine(f.FullName);
            Console.WriteLine(f.Exists);
        }

        static void f1_read()
        {
            FileStream fs = new FileStream(@"C:\test\file1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadLine();
            Console.WriteLine(s);

            sr.Close();
            fs.Close();
        }

        static void f1_write()
        {
            FileStream fs = new FileStream(@"C:\test\file1.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("Hello");
            sw.WriteLine("Hello2");

            

            sw.Close();
            fs.Close();
        }

        static void f2()
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\test");
            Console.WriteLine(d.Name);
            Console.WriteLine(d.FullName);
            Console.WriteLine(d.LastWriteTime);
        }

        static void Main(string[] args)
        {
            f1_write();

            Console.ReadKey();
        }
    }
}
