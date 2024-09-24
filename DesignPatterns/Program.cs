using DesignPatterns.AdapterDP;
using DesignPatterns.StructuralDP.AdapterDP;
using DesignPatterns.StructuralDP.Bridge_DP;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    enum tempType
    {
        celcius,
        fahrenheit
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //adapter dp

            while (true)
            {
                Console.WriteLine("Temp Type : ");
                string TempType = Console.ReadLine();

                tempType tempTypeEnum;
                if (!Enum.TryParse(TempType, true, out tempTypeEnum))
                {
                    Console.WriteLine("Invalid temperature type!");
                    return;
                }



                Console.WriteLine("Mention Temp : ");
                double Temperature = Convert.ToDouble(Console.ReadLine());
                switch (tempTypeEnum)
                {
                    case tempType.celcius:
                        Celcius celcius = new Celcius(Temperature);
                        Console.WriteLine("Celcius temperatue : " + celcius.GetTempinCelcius() + " C");
                        break;
                    case tempType.fahrenheit:

                        Fahrenheit fahrenheit = new Fahrenheit(Temperature);
                        CelciusFahrenheitAdapter celciusFahrenheitAdapter = new CelciusFahrenheitAdapter(fahrenheit);
                        Console.WriteLine($"Fahrenheit {Temperature} to Celcius temperatue Conversion: " + celciusFahrenheitAdapter.GetTempinCelcius()+" C");
                        //Console.WriteLine("Fahrenheit temperatue : " + fahrenheit.GetTempinFahrenheit());
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
