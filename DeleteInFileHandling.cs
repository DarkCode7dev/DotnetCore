﻿using System;
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
            //string s = @"Desktop\\batman.txt";
            //string s2 = @"Desktop\\batch4.txt";

          

            DirectoryInfo di = new DirectoryInfo(@"f:\5 sem");
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                foreach (FileInfo s in dir.GetFiles())
                {
                    s.Delete();
                }
                dir.Delete();
            }
        }
    }
}
