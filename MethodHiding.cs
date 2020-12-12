
namespace Day5
{
    class one
    {
       public static void show()
        {
            Console.WriteLine("hello");
        }
    }

    class second : one
    {
        public static void show()
        {
            Console.WriteLine("hey");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            one.show();
            second.show();
            Console.ReadLine();
        }
    }
}
