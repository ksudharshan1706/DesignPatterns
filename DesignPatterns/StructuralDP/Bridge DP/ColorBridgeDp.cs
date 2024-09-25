using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDP.Bridge_DP
{

    //Implementor
    public interface Icolor
    {
        string ApplyColor();
    }

    public class RedColor : Icolor
    {
        public string ApplyColor()
        {
            return "RED";
        }
    }

    public class GreenColor : Icolor
    {
        public string ApplyColor()
        {
            return "GREEN";
        }
    }

    

    //abstraction
    public abstract class Shape
    {
        protected Icolor color;
        public Shape(Icolor color)
        {
            this.color = color;
        }

        public abstract void Draw();
    }


    public class CircleShape : Shape
    {
        public double radius;
        public CircleShape(double radius, Icolor color):base(color)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Circle with {this.radius} with {color.ApplyColor()} color");
        }

    }

    public class SquareShape : Shape
    {
        public double side;
        public SquareShape(double side, Icolor color) : base(color)
        {
            this.side = side;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Square with {this.side} with {color.ApplyColor()} color");
        }

    }



    public class ColorBridgeDp
    {

        public ColorBridgeDp()
        {
            Shape redCirle = new CircleShape(10, new RedColor());
            Shape greenSquare = new SquareShape(7.5, new GreenColor());

            redCirle.Draw();
            greenSquare.Draw();
        }
    }
}
