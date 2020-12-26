using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thday
{

    class one
    {
        int height;
        int radius;

        public one(int x, int y)
        {
            height = x;
            radius = y;
        }

        public void volume()
        {
            double result = Math.PI * radius * radius * height;
            Console.WriteLine(result);
        }

        public void surface()
        {
            double t = 2 * Math.PI * radius * height;
            Console.WriteLine(t);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            one k = new one(1,5);
            k.volume();
            k.surface();
             Console.ReadLine();
        }
    }

   
}
