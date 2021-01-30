using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace day17
{
    class one<T,K>
    {
        public void add(T a, K b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            one<int,string> o = new one<int,string>();
            o.add(4, "Dev");

            Console.ReadLine();
        }
    }
}
