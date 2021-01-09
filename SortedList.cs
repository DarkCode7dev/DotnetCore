using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace day13
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList k = new SortedList();
            k.Add(40, "ravi");
            k.Add(112, "mohan");
            k.Add(567, "Praveen");
            k.Add(100, "ram");
            k.Add(102, "harshit");

            foreach (DictionaryEntry s in k)
            {
                Console.WriteLine(s.Key + ":" + s.Value);
            }
            Console.ReadLine();
        }
    }
}
