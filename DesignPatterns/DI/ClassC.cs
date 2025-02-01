using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DI
{
    public class ClassC : IclassInterface
    {
        public void funcA()
        {
            Console.WriteLine("CLass C funcA");
        }

        public void funcB()
        {
            Console.WriteLine("CLass C funcB");
        }

    }
}
