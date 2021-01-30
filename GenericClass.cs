using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day17
{

    class one<T>
    {
        internal void add(T v1, T v2)
        {
            Console.WriteLine(v1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            one<int> k = new one<int>();
            k.add(4, 5);
            Console.ReadLine();
        }
    }
}
