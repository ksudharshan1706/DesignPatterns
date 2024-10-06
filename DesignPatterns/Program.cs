using DesignPatterns.AdapterDP;
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

            var shop = new CoffeeShop();
            shop.TakeOrders("Cappuccino", 1);
            shop.TakeOrders("Espresso", 2, "With extra sugar");
            shop.TakeOrders("Cappuccino", 3);
            shop.TakeOrders("Latte", 4);
            shop.ServeOrder();

            Console.ReadKey();

        }
    }
}
