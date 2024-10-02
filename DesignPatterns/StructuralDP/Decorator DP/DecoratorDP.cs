using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDP.Decorator_DP
{
    public interface Icoffee
    {
        string getCoffee();
    }
    public class Coffee : Icoffee
    {
        public string getCoffee()
        {
            return "This is a Expresso";
        }
    }
    public class DecoratorDP : Icoffee
    {
        private Icoffee _coffee;
        public DecoratorDP(Icoffee coffee) 
        {
            _coffee = coffee;
        }
        public virtual string getCoffee()
        {
            return _coffee.getCoffee();
        }
    }
    
    public class WhippedCreamDecorator : DecoratorDP
    {
        public WhippedCreamDecorator(Icoffee coffee) : base(coffee) { }

        public override string getCoffee()
        {
            string Type = base.getCoffee();
            Type += "\r\n with whippedCream";
            return Type;
        }
    }
    public class MilkDecorator : DecoratorDP
    {
        public MilkDecorator(Icoffee coffee) : base(coffee) { }

        public override string getCoffee()
        {
            string Type = base.getCoffee();
            Type += "\r\n with Extra Milk";
            return Type;
        }
    }
    public class SugarDecorator : DecoratorDP
    {
        public SugarDecorator(Icoffee coffee) : base(coffee) { }

        public override string getCoffee()
        {
            string Type = base.getCoffee();
            Type += "\r\n with Extra Sugar";
            return Type;
        }
    }


}
