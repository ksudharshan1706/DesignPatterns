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

    delegate void Calculator(int x, int y);
    public class Program
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Mul(int c, int d)
        {
            Console.WriteLine(c * d);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        //Delegate:

        //delegate is a variable which refers to the Method or points to the method.
        //a single delegate can refer to one or more methods with same return type and no. of parameters.
        // when we try to send a method as a parameter to a function we can use a delegate.

        static void Main(string[] args)
        {
            Calculator cal = new Calculator(Sub);
            cal += Mul;
            cal(10, 20);


            Console.ReadKey();

        }
    }
}

//Multi-cast Delegate:
//a multi cast delegate is a delegate which holds reference to more than one method.

