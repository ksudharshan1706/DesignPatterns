using DesignPatterns.AdapterDP;
using DesignPatterns.DI;
using DesignPatterns.StructuralDP.AdapterDP;
using DesignPatterns.StructuralDP.Facade_DP;
using DesignPatterns.StructuralDP.Facade_DP.RealTimeExample;
using DesignPatterns.StructuralDP.Flyweight_DP;
using DesignPatterns.StructuralDP.Flyweight_DP.RealTimeExample;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    enum currencyType
    {
        dollar,
        rupee
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Coffee Flyweight DP


            //IclassInterface classinstance = new ClassA();
            IclassInterface classinstance = new ClassC();
            ClassB cb = new ClassB(classinstance);
            cb.funcA();
            cb.funcB();

            Console.ReadKey();

        }
    }
}
