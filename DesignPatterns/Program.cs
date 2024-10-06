using DesignPatterns.AdapterDP;
using DesignPatterns.StructuralDP.AdapterDP;
using DesignPatterns.StructuralDP.Decorator_DP;
using DesignPatterns.StructuralDP.Facade_DP;
using DesignPatterns.StructuralDP.Facade_DP.RealTimeExample;
using DesignPatterns.StructuralDP.Flyweight_DP;
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

            //Flyweight DP

            Console.WriteLine("\n Red color Circles ");
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.setColor("Red");
                circle.Draw();
            }
            //Creating Circle Objects with Green Color
            Console.WriteLine("\n Green color Circles ");
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.setColor("Green");
                circle.Draw();
            }
            //Creating Circle Objects with Blue Color
            Console.WriteLine("\n Blue color Circles");
            for (int i = 0; i < 3; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.setColor("Green");
                circle.Draw();
            }
            //Creating Circle Objects with Orange Color
            Console.WriteLine("\n Orange color Circles");
            for (int i = 0; i < 3; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.setColor("Orange");
                circle.Draw();
            }
            //Creating Circle Objects with Black Color
            Console.WriteLine("\n Black color Circles");
            for (int i = 0; i < 3; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.setColor("Black");
                circle.Draw();
            }
            Console.ReadKey();

        }
    }
}
