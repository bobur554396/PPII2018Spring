using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarExampleFolders
{
    class Program
    {

        static void f1(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);

            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo d in dirs)
                Console.WriteLine(d.Name);

            FileInfo[] files = dir.GetFiles();
            for (int i = 0; i < files.Length; i++)
                Console.WriteLine(files[i].Name);

        }

        static void f2(string path, int depth = 0)
        {
            DirectoryInfo dir = new DirectoryInfo(path);

            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo d in dirs)
            {
                for (int i = 0; i < depth; i++) Console.Write(" ");
                Console.WriteLine(d.Name);
                f2(d.FullName, depth + 5);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo f in files)
            {
                for (int i = 0; i < depth; i++) Console.Write(" ");
                Console.WriteLine(f.Name);
            }

            
        }

        static void Main(string[] args)
        {
            f2(@"C:\test");

            Console.ReadKey();
        }
    }
}
