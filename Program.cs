using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    interface emp
    {
        void salary(int hr, int rupes);

        void tax(int s);

        void total_salay();

        void month_salary();
    }

    class Engineer : emp
    {
        int sal;
        int tx;
        int total;
        int month;
        public void month_salary()
        {
            month = total * 30;
            Console.WriteLine($"this is total salary of month  {month}");
        }
     

        public void salary(int hr, int rupes)
        {
            sal = hr * rupes;
            Console.WriteLine(sal);
        }

        public void tax(int s)
        {
            tx = sal * s / 100;
            Console.WriteLine(tx);
        }
        
        public void total_salay()
        {
            total = sal - tx;
                        Console.WriteLine(total);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Engineer k = new Engineer();
            k.salary(5, 400);
            k.tax(5);
            k.total_salay();
            k.month_salary();
            Console.ReadLine();
        }
    }
}
