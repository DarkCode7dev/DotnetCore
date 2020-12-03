using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IMyDependency depObj = new MyDependency();
            Consumer obj = new Consumer(depObj);
            obj.ConsumeThings();
        }
    }
}
