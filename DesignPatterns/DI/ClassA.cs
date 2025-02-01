using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DI
{
    public class ClassA : IclassInterface
    {
        public void funcA()
        {
            Console.WriteLine("CLass A funcA");
        }

        public void funcB()
        {
            Console.WriteLine("CLass A funcB");
        }

    }
}
