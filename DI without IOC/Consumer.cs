using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
   public class Consumer
    {
        IMyDependency _dependency;
        public Consumer(IMyDependency dependency)
        {
            _dependency = dependency;
        }
        //  MyDependency _dependency = new MyDependency();


        public void ConsumeThings()
        {
            _dependency.WriteMessage("Learn in Devesh");

        }
    }
}
