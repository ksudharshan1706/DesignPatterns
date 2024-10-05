using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDP.Facade_DP.RealTimeExample
{
    public class CustomerRegistrationApp
    {
        public Customer customer;
        public CustomerRegistrationApp(Customer customer) 
        {
            this.customer = customer;
        }

        public void RegisterCustomer()
        {
            CustomerValidator customerValidator = new CustomerValidator(customer);
            ValidationResult validation = customerValidator.validateCustomer();
            if (validation.Status)
            {
                CustomerDataAccessLayer customerDataAccessLayer = new CustomerDataAccessLayer();
                bool isSaved = customerDataAccessLayer.SaveData(customer);
                if (isSaved)
                {
                    Console.WriteLine("Data Saved");
                }
                else
                {
                    Console.WriteLine("Issue while saving data");
                }
                //Email email = new Email();
                //email.sendRegistrationEmail(customer);
            }
            else
            {
                Console.WriteLine(validation.Message);
            }
        }


    }
}
