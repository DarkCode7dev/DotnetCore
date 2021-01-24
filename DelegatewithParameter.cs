using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16
{
    public delegate void del(int x,int y);
    class one
    {
        public void add(int a, int b)
        {
            int c;
            c = a + b;
            Console.WriteLine(c);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            one k = new one();

            del s = new del(k.add);
            s(4,5);
            Console.ReadLine();

        }
    }
}
