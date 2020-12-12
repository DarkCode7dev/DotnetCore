class one
    {
      public  int a = 12, b = 20, c;
        public void add()
        {
            c = a + b;
            Console.WriteLine(c);
        }
    }

    class second: one
    {
        public void mul()
        {
            c = a * b;
            Console.WriteLine(c);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            second p = new second();
            p.add();
            p.mul();
            Console.ReadLine();
        }
    }
