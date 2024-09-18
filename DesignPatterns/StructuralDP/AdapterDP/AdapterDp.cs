using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterDP
{
    public class RoundHole
    {
        public double radius;
        public RoundHole(double rradius)
        {
            this.radius = rradius;
        }
        public double getRadius()
        {
            return this.radius;

        }
        public bool fits(RoundPeg peg)
        {
            return this.radius >= peg.getRadius();
        }
    }

    public class RoundPeg
    {
        public double radius;
        public RoundPeg(double radius)
        {
            this.radius = radius;
        }
        public virtual double getRadius()
        {
            return this.radius;
        }
    }

    public class SquarePeg
    {
        public double width;
        public SquarePeg(double width)
        {
            this.width = width;
        }
        public double getWidth()
        {
            return this.width;
        }

    }

    public class AdapterDp : RoundPeg
    {
        public SquarePeg SquarePeg;
        public AdapterDp(SquarePeg peg) : base(0)
        {
            this.SquarePeg = peg;
        }

        public override double getRadius()
        {
            return this.SquarePeg.getWidth() * Math.Sqrt(2) / 2;
        }
    }

}
