using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDP.AdapterDP
{
    public class Celcius
    {
        public double temp;
        public Celcius(double temp)
        {
            this.temp = temp;
        }

        public virtual double GetTempinCelcius()
        {
            return this.temp;
        }
    }

    public class Fahrenheit
    {
        public double temp;
        public Fahrenheit(double temp)
        {
            this.temp = temp;
        }

        public double GetTempinFahrenheit()
        {
            return this.temp;
        }
    }



    public class CelciusFahrenheitAdapter : Celcius
    {
        public Fahrenheit Fahrenheit;

        public CelciusFahrenheitAdapter(Fahrenheit fahrenheit) : base(0)
        {
            this.Fahrenheit = fahrenheit;
        }   
        
        public override double GetTempinCelcius()
        {
            return (this.Fahrenheit.GetTempinFahrenheit()-32)*(5.0/9.0) ;
        }
    }
}
