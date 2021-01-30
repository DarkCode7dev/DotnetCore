using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace day17
{
    class one
    {
        public void add<T,K>(T a, K b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            one o = new one();
            o.add(4, 5.7);

            Console.ReadLine();
        }
    }
}
