using DesignPatterns.AdapterDP;
using DesignPatterns.StructuralDP.AdapterDP;
using DesignPatterns.StructuralDP.Bridge_DP;
using DesignPatterns.StructuralDP.Decorator_DP;
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

            //Decorator Dp

            Icoffee coffee = new Coffee();
            Icoffee whippedcreamCoffee = new WhippedCreamDecorator(coffee);
            Icoffee MilkCoffee = new MilkDecorator(whippedcreamCoffee);
            Icoffee sugarCoffee = new SugarDecorator(MilkCoffee);

            Console.WriteLine(sugarCoffee.getCoffee());
           


            Console.ReadLine(); 

        }
    }
}
