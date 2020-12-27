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
            Stack p = new Stack();

            Stack s = new Stack();
            s.Push("gaurav");
            s.Push("tomar");
            s.Push("ravi");
            s.Push(123);
            s.Push(456);
            s.Push(100);
            s.Push("kumar");
            //p = s.CopyTo(p,s);//error
            //s.Pop();
            //s.Pop();
            //Console.WriteLine(s.Contains("tomar"));
            //Console.WriteLine(s.Count);
            //s.Clear();
            //foreach (object r in s)
            //{
            //    Console.WriteLine(r);
            //}
            //Console.WriteLine(s.Peek());
            Console.ReadKey();
        }
    }
}
