using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    class one
    {
        public void div(int x,int y)
        {
            if (y==2)
            {
                throw new Exception("you can not divide by 2");
            }
            else
            {
                int z;
                z = x / y;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            one k = new one();
            try
            {
                k.div(10, 2);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            Console.WriteLine("hello");
            Console.ReadLine();
        }
    }
}
