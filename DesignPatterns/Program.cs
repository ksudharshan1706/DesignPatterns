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
    enum currencyType
    {
        dollar,
        rupee
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //adapter dp

            while (true)
            {
                Console.WriteLine("currency Type : ");
                string CurrencyType = Console.ReadLine();

                currencyType currencyTypeEnum;
                if (!Enum.TryParse(CurrencyType, true, out currencyTypeEnum))
                {
                    Console.WriteLine("Invalid currency type!");
                    return;
                }



                Console.WriteLine("Mention amount : ");
                double amount = Convert.ToDouble(Console.ReadLine());
                switch (currencyTypeEnum)
                {
                    case currencyType.dollar:
                        DollarPayment dollar = new DollarPayment(amount);
                        Console.WriteLine("Dollar Amount : " + dollar.GetAmountinDollars() + " $");
                        break;
                    case currencyType.rupee:
                        RupeePayment rupeePayment = new RupeePayment(amount);
                        PaymentDp paymentDp = new PaymentDp(rupeePayment);
                        Console.WriteLine("Rupee to Dollar Amount : " + paymentDp.GetAmountinDollars() + " $");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
