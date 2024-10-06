using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDP.Flyweight_DP.RealTimeExample
{
    public class Coffee
    {
        public string Flavour { get; set; }
        public string Ingredients { get; set; }
        public string Preparation {  get; set; }

        public Coffee(string flavour, string ingredients, string preparation) 
        {
            Flavour = flavour;
            Ingredients = ingredients;
            Preparation = preparation;
        }

        public void serveCoffee(int tableNumber,string Customisations = "")
        {
            Console.WriteLine($"Serving {Flavour} coffee (made with {Ingredients} and {Preparation}) to table {tableNumber}. {Customisations}");
        }
    }

    public class CoffeeFactory
    {
        private readonly Dictionary<string, Coffee> _coffee = new Dictionary<string, Coffee>();

        public Coffee GetCoffee(string flavour) 
        {
            if(!_coffee.ContainsKey(flavour))
            {
                var coffee = new Coffee(flavour, "water", "brewed");
                _coffee.Add(flavour, coffee);
            }
            return _coffee[flavour];
        }
    }

    public class CoffeeShop
    {
        private readonly CoffeeFactory coffeeFactory = new CoffeeFactory();
        private readonly List<Tuple<Coffee,int,string>> _orders = new List<Tuple<Coffee, int, string>>();

        public void TakeOrders(string flavour,int tablenumber,string customisations = "")
        {
            var coffee = coffeeFactory.GetCoffee(flavour);
            _orders.Add(Tuple.Create(coffee, tablenumber, customisations));
        }

        public void ServeOrder()
        {
            foreach( var order in _orders)
            {
                order.Item1.serveCoffee(order.Item2, order.Item3);
            }
            _orders.Clear();
        }

    }
}
