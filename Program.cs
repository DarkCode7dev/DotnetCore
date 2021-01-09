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
            DictionaryEntry[] dictArr = new DictionaryEntry[7];
            s.CopyTo(dictArr, 0);
            for (int i = 0; i < dictArr.Length; i++)
            {
                Console.WriteLine("Key= " + dictArr[i].Key + "Value = " + dictArr[i].Value);
            }
            Console.ReadLine();
        }
    }
}
