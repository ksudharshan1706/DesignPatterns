using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDP.AdapterDP
{
    public class DollarPayment
    {
        private double amount;
        public DollarPayment(double amount)
        {
            this.amount = amount;
        }
        public virtual double GetAmountinDollars()
        {
            return amount;
        }
    }


    public class RupeePayment
    {
        private double amount;
        public RupeePayment(double amount)
        {
            this.amount = amount;
        }
        public double GetAmountinRupees()
        {
            return amount;
        }
    }

    public class PaymentDp : DollarPayment
    {
        public RupeePayment rupeePayment;

        public PaymentDp(RupeePayment rupeePayment) : base(0)
        {
            this.rupeePayment = rupeePayment;
        }

        public override double GetAmountinDollars()
        {
            return this.rupeePayment.GetAmountinRupees()*(80.0);
        }


    }
}
