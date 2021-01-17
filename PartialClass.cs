using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
   partial class Manager{
        public void show()
        {
            Console.WriteLine("I am Manager");
        }

    }

    partial class Manager
    {
        public void show2()
        {
            Console.WriteLine("I am Manager2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            Manager k = new Manager();
            k.show();
            k.show2();
           
            Console.ReadLine();
        }
    }
}
