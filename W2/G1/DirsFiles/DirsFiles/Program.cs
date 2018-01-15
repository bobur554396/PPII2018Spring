using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirsFiles
{
    class Program
    {
        static void f1()
        {
            FileInfo f = new FileInfo(@"C:\test\file1.txt");

            Console.WriteLine(f.Name);
            Console.WriteLine(f.FullName);

            DirectoryInfo dir = new DirectoryInfo(@"C:\test");

            Console.WriteLine(dir.FullName);
        }


        static void f2()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\test");
            FileInfo[] files = dir.GetFiles();

            for (int i = 0; i < files.Length; i++)
                Console.WriteLine(files[i].Name);   
        }

        static void f3()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\test");
            DirectoryInfo[] dirs = dir.GetDirectories();

            for (int i = 0; i < dirs.Length; i++)
                Console.WriteLine(dirs[i].Name);
        }

        static void f4()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\test");
            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (DirectoryInfo d in dirs)
                Console.WriteLine(d.Name);

            foreach (FileInfo f in files)
                Console.WriteLine(f.Name);
        }


        static void f5(string path, int depth = 0)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (DirectoryInfo d in dirs)
            {
                for (int i = 0; i < depth; i++) Console.Write(" ");
                Console.WriteLine(d.Name);
                f5(d.FullName, depth + 5);
            }

            foreach (FileInfo f in files) {
                for (int i = 0; i < depth; i++) Console.Write(" ");
                Console.WriteLine(f.Name);
            }

            
        }

        static void Main(string[] args)
        {
            f5(@"C:\test");

            Console.ReadKey();
        }
    }
}
