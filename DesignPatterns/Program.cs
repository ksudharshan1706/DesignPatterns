using DesignPatterns.AdapterDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Adapter DP
            
            RoundHole roundHole = new RoundHole(5);
            Console.WriteLine("Hole Radius : "+roundHole.getRadius().ToString());

            RoundPeg roundPeg = new RoundPeg(5);
            Console.WriteLine("peg Radius : " + roundPeg.getRadius().ToString());

            RoundPeg roundPeg_large = new RoundPeg(10);
            Console.WriteLine("peg Radius : " + roundPeg_large.getRadius().ToString());

            Console.WriteLine("will the peg fit in Round hole : " + roundHole.fits(roundPeg));
            Console.WriteLine("will the Large peg fit in Round hole : " + roundHole.fits(roundPeg_large));

            SquarePeg squarePeg = new SquarePeg(5);
            //roundHole.fits(squarePeg);
            //incompatible because the roundHole only takes only RoundPeg object

            // trying to achieve it with adapter.
            AdapterDp adapterDp = new AdapterDp(squarePeg);
            Console.WriteLine("get adapter radius : " + adapterDp.getRadius());
            Console.WriteLine("will the adapter fit in Round hole : " + roundHole.fits(adapterDp));


            Console.ReadLine();
        }
    }
}
