using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8thday
{

    abstract class emp {
        public int total;
        public int tx;
        public int sal; 

        public abstract void salary(int hr, int rupes);
        public abstract void tax(int s);
        public abstract void total_salary();
        public void show()
        {
            Console.WriteLine("hello");
        }
    }

    class second : emp,fruits
    {
        public override void salary(int hr, int rupes)
        {
            sal = hr * rupes;
            Console.WriteLine(sal);
        }

        public override void tax(int s)
        {
            tx = sal * tx / 100;
            Console.WriteLine(tx);
        }

        public override void total_salary()
        {
            total = sal - tx;
            Console.WriteLine(total);
        }

        public void color()
        {
            Console.WriteLine("red");
        }

        public void size()
        {
            Console.WriteLine("oval");
        }

    }

    interface fruits
    {
        public abstract void color();

        public abstract void test();
        public abstract void size();

    }
    class Program
    {
        static void Main(string[] args)
        {
            second k = new second();
            k.salary(5, 400);
            k.tax(5);
            k.total_salary();
            k.show();
            Console.ReadLine();

        }
    }
}
