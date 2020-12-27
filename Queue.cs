using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _10Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue k = new Queue();
            k.Enqueue("kim");
            k.Enqueue("sachin");
            k.Enqueue("ramayan");
            k.Enqueue(123);
            k.Enqueue(100);
            k.Dequeue();

            foreach (object item in k)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
