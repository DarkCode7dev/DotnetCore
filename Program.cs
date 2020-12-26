using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thday
{

    static class one
    {
        static int a = 12;
        static int b = 12;
        static int s;
        public static void add()
        {
            s = a + b;
            Console.WriteLine(s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            one.add();
          
             Console.ReadLine();
        }
    }

   
}
