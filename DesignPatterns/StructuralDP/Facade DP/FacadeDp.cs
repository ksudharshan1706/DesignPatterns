using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDP.Facade_DP
{
    public class FacadeDp
    {
        public void placeOrder()
        {
            Product product = new Product();
            product.getProductDetails();
            
            Payment payment = new Payment();
            payment.makePayment();

            Invoice invoice = new Invoice();
            invoice.generateInvoice();

            Console.WriteLine("Order Placed");

        }
    }

    public class Product
    {
        public void getProductDetails()
        {
            Console.WriteLine("Product information");
        }
    }

    public class Payment
    {
        public void makePayment()
        {
            Console.WriteLine("Payment made");
        }
    }

    public class Invoice
    {
        public void generateInvoice()
        {
            Console.WriteLine("Invoice Generated");
        }
    }
}
