using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDP.Bridge_DP
{

    public interface Ishape
    {
        string Name { get; }
        void Draw();
        void getShapeName();

    }

    public class Color
    {
        public Ishape shape;
        public Color(Ishape shape) 
        { 
            this.shape = shape;
        }
        public void Draw()
        {
            this.shape.Draw();
        }

        public void getShapeName()
        {
            this.shape.getShapeName();
        }
    }

    public class Circle:Ishape
    {
        public string Name { get; set; }
        public Circle(string name)
        {
            this.Name = name;
        }

        public void Draw()
        {
            Console.WriteLine($"{this.Name} Draw");
        }

        public void getShapeName()
        {
            Console.WriteLine($"Shape name is {this.Name}");
        }
        
    }

    public class Square : Ishape
    {
        public string Name { get; set; }
        public Square(string name)
        {
            this.Name = name;
        }

        public void Draw()
        {
            Console.WriteLine($"{this.Name} Draw");
        }

        public void getShapeName()
        {
            Console.WriteLine($"Shape name is {this.Name}");
        }

    }

    public class ShapeBridgeDp
    {
        Circle circle;
        Square square;
        Color Color;
        public ShapeBridgeDp()
        {
            circle = new Circle("Circle");
            square = new Square("Square");

            Color = new Color(circle);
            Color.Draw();
            Color.getShapeName();


            Color = new Color(square);
            Color.Draw();
            Color.getShapeName();



        }
    }
}
