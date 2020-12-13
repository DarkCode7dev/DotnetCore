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
            k.Salary = 9000;
            Console.WriteLine(k.Salary);

            Console.ReadLine();
        }
    }

    public class one
    {public int Salary
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value;
            }
        }
    }
}
