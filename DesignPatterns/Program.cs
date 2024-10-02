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


            IPizza pizza = new Pizza();
            //IPizza CheesePizza = new CheeseDecorator(pizza);
            //IPizza TomatoPizza = new TomatoDecorator(pizza);
            //IPizza OnionPizza = new OnionDecorator(pizza);
            IPizza CheesePizza = new CheeseDecorator(pizza);
            IPizza TomatoPizza = new TomatoDecorator(CheesePizza);
            IPizza OnionPizza = new OnionDecorator(TomatoPizza);



            //Console.WriteLine(CheesePizza.getPizzaType());
            //Console.WriteLine(TomatoPizza.getPizzaType());
            Console.WriteLine(OnionPizza.getPizzaType());

            Console.ReadLine(); 

        }
    }
}
