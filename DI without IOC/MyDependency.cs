using System;

namespace DependencyInjection
{
    public class MyDependency : IMyDependency
    {
        public MyDependency()
        {

        }


        public void WriteMessage(string message)
        {
            Console.WriteLine($"MyDependency.WriteMessage called . Message: {message}");
        }
    }
}