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

        public void show2()
        {
            Console.WriteLine("ducat");
        }

        public void show3()
        {
            Console.WriteLine("India");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            one k = new one();

            del p = new del(k.show);
            p += new del(k.show2);
            p += new del(k.show3);
            p -= new del(k.show2);
            p();
            Console.ReadLine();

        }
    }
}
