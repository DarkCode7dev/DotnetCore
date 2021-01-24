using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16
{
    public delegate void del();
    class one
    {
        public void show()
        {
            Console.WriteLine("hello");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            one k = new one();

            del s = new del(k.show);
            s();
            Console.ReadLine();

        }
    }
}
