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
            Hashtable s = new Hashtable();
            s.Add(123, "gaurav");
            s.Add(456, "ravi");
            s.Add(783, "mohan");
            s.Add(100, "rohan");
            s.Add(600, "kumar");
            s.Add(189, "rahish");
            s.Add(200, "dev");
            foreach (DictionaryEntry n in s)
            {
                Console.WriteLine(n.Key + ":" + n.Value);
            }
            Hashtable p = new Hashtable();
            p = (Hashtable)s.Clone();

            foreach (DictionaryEntry m in p)
            {
                Console.WriteLine(m.Key + ":" + m.Value);
            }
          
            Console.ReadLine();
        }
    }
}
