using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int x = 10;
                int y = 0;
                int z=0;
                z = x / y;
                Console.WriteLine(z);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("hello");
            }
           
            Console.ReadLine();
        }
    }
}
