using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thday
{

    class one
    {
       static int height;
       static int radius;
        static one()
        {
            height = 15;
            radius = 20;
        }

        public void volume()
        {
            double result = Math.PI * radius * radius * height;
            Console.WriteLine(result);
        }

        public void surface()
        {
            double result2 = 2 * Math.PI * radius * height;
            Console.WriteLine(result2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            one k = new one();

            k.surface();
            k.volume();
             Console.ReadLine();
        }
    }

   
}
