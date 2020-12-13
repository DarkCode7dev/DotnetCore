using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{


    class Program
    {
        static void Main(string[] args)
        {
            one k = new one();
            k.setsalary(50000);
            Console.WriteLine(k.getsalary());
            Console.ReadLine();
        }
    }

    public class one
    {
        int salary = 20000;
       public int getsalary()
        {
            return salary;

        }

        public void setsalary(int t)
        {
            salary = t;
        }
    }
}
