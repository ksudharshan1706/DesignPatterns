using DesignPatterns.AdapterDP;
using DesignPatterns.StructuralDP.AdapterDP;
using DesignPatterns.StructuralDP.Bridge_DP;
using DesignPatterns.StructuralDP.Decorator_DP;
using DesignPatterns.StructuralDP.Facade_DP;
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

            //Facade Dp

            FacadeDp facadeDp = new FacadeDp();
            facadeDp.placeOrder();
            Console.ReadLine(); 


        }
    }
}
