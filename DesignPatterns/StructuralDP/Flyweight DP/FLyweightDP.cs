using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDP.Flyweight_DP
{
    public interface IShape
    {
        void Draw();
    }
    public class Circle : IShape
    {
        public string _color { get; set; }

        public readonly double _radius = 20;
        public readonly int X_cood = 10;
        public readonly int Y_cood = 15;

        public void setColor(string color)
        {
            _color = color;
        }

        public void Draw()
        {
            Console.WriteLine($"Drew a {_color} circle at {X_cood} and {Y_cood} with a radius of {_radius}");
        }
    }

    public class ShapeFactory
    {
        private static Dictionary<string, IShape> shapeMap = new Dictionary<string, IShape>();

        public static IShape GetShape(string shapeType)
        {
            IShape shape = null;

            if (shapeType.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
            {
                if (shapeMap.TryGetValue(shapeType, out shape))
                {
                    return shape;
                }
                else
                {
                    shape = new Circle();
                    shapeMap.Add(shapeType, shape);
                    Console.WriteLine("Creating circle object without any color in shapeFactory \n");
                }
            }

            return shape;

        }
    }
}
