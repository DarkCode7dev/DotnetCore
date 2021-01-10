using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace day14
{
    class Program
    {
        static void Main(string[] args)
        {
           

            try
            {
                int x = 10;
                int y = 0;
                int z;
                z = x / y;
                Console.WriteLine(z);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            Console.WriteLine("hello ducat");
            Console.ReadLine();
        }
    }
}
