using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDP.Decorator_DP
{

    public interface IPizza
    {
        string getPizzaType();
    }

    public class Pizza : IPizza
    {
        public string getPizzaType() 
        {
            return "This is a normal pizza";
        }
    }
    public class PizzaBaseDecorator : IPizza
    {
        private IPizza _pizza;
        public PizzaBaseDecorator(IPizza pizza)  
        {
            _pizza = pizza;
        }
        public virtual string getPizzaType() 
        {
            return _pizza.getPizzaType();
        }
    }

    public class CheeseDecorator : PizzaBaseDecorator
    {
        public CheeseDecorator(IPizza pizza):base(pizza){ }

        public override string getPizzaType() 
        { 
            string type = base.getPizzaType();
            type += "\r\n with extra cheese";
            return type;
        }


    }
    public class TomatoDecorator : PizzaBaseDecorator
    {
        public TomatoDecorator(IPizza pizza):base(pizza){ }

        public override string getPizzaType() 
        { 
            string type = base.getPizzaType();
            type += "\r\n with extra Tomato";
            return type;
        }


    }
    public class OnionDecorator : PizzaBaseDecorator
    {
        public OnionDecorator(IPizza pizza):base(pizza){ }

        public override string getPizzaType() 
        { 
            string type = base.getPizzaType();
            type += "\r\n with extra onions";
            return type;
        }


    }

}
