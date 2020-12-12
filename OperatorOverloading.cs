using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class one
    {
        int x;
        int y;
        public one(int a, int b)
        {
            x = a;
            y = b;

        }

        public void mul()
        {
            int c;
            c = x * y;
            Console.WriteLine(c);
        }

        public static one operator +(one c1, one c2)
        {
            one temp = new one(5, 6);
            temp.x = c1.x + c2.x;
            temp.y = c1.y + c2.y;
            return temp;
        }

        public void ShowXY()
        {
            Console.WriteLine("{0} {1}", x,y);
        }
    }
    class Program
    {
        

        static void Main(string[] args)
        {
            one l = new one(5,6);
          
            one l2 = new one(4, 5);
            one l3 = new one(1, 1);
            l3 = l + l2;
            l3.ShowXY();
            Console.ReadLine();
        }
    }

}
