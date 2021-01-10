using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace day14
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = @"F\\co5\\batman.txt";
            //string s2 = @"F\\co5\\batch4.txt";

            //File.Copy(s, s2, true);

            //DirectoryInfo di = new DirectoryInfo(@"f:\5 sem");
            //foreach (DirectoryInfo dir in di.GetDirectories())
            //{
            //    foreach (FileInfo s in dir.GetFiles())
            //    {
            //        s.Delete();
            //    }
            //    dir.Delete();
            //}

            try
            {
                int x = 10;
                int y = 0;
                int z;
                z = x / y;
                Console.WriteLine(z);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            Console.WriteLine("hello ducat");
            Console.ReadLine();
        }
    }
}
