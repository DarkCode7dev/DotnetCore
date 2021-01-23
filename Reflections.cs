using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Practice
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer()
        {
            this.Id = 1;
            this.Name = string.Empty;
        }

        public void PrintID()
        {
            Console.WriteLine(this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine(this.Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            Type T = c1.GetType();
            Console.WriteLine(T.FullName);
            Console.WriteLine(T.Name);
            Console.WriteLine(T.Namespace);
            Console.WriteLine("properties in Customer");
            PropertyInfo[] properties = T.GetProperties();
            //give property
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name+ " " + property.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Methods in Customers");
            MethodInfo[] methods = T.GetMethods();
            //for methods
            foreach (MethodInfo Methods  in methods  )
            {
                Console.WriteLine(Methods.ReflectedType.Name + " "+ Methods.Name);
            }
            Console.WriteLine();
            Console.WriteLine("constructor in customer");
            ConstructorInfo[] consts = T.GetConstructors();
            foreach (ConstructorInfo Constructor in consts)
            {
                Console.WriteLine(Constructor.ToString());
            }
            Console.ReadLine();
        }
    }
}
