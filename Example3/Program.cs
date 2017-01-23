using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            F5();
        }

        private static void F5()
        {
            ConsoleKeyInfo pressedKey = Console.ReadKey();
            if (pressedKey.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Escape!");
            }
            else if (pressedKey.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Enter!");
            }
            else if (pressedKey.Key == ConsoleKey.A)
            {
                Console.WriteLine("A!");
            }
        }

        private static void F4()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\QtSDK\mingw");

            foreach (FileSystemInfo x in dir.GetFileSystemInfos())
            {
                Console.WriteLine(x.Name);
            }
        }

        private static void F3()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\QtSDK\mingw");
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                Console.WriteLine(d.Name);
            }

            foreach (FileInfo f in dir.GetFiles())
            {
                Console.WriteLine(f.Name);
            }
        }

        private static void F2()
        {
            FileStream fs = new FileStream(@"C:\work\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string text = sr.ReadToEnd();

            Console.WriteLine(text);

            sr.Close();
            fs.Close();
        }

        private static void F1()
        {
            FileStream fs = new FileStream(@"C:\work\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("Hello world!");

            sw.Close();
            fs.Close();
        }
    }
}
