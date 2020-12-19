using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    interface emp
    {
        void show();


       
    }

    interface emp2
    {
         void show();


    }

    class Engineer : emp,emp2
    {
         void emp.show()
        {
            Console.WriteLine("hello");
        }

         void emp2.show()
        {
            Console.WriteLine("hey");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Engineer k = new Engineer();
            emp2 test = k;
            emp p = k;
            test.show();
            p.show();

           

            Console.ReadLine();
        }
    }
}
