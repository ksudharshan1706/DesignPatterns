using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDP.Facade_DP.RealTimeExample
{
    public class Customer
    {
        private string _custName { get; set; }
        private string _custPhNo { get; set; }
        private string _custEmail { get; set; }
        private string _custAddress { get; set; }
        
        public Customer(string name, string phNo, string email,string address)
        {
            _custName = name;
            _custPhNo = phNo;
            _custEmail = email;
            _custAddress = address;
        }

        public string getCustomerName()
        {
            return _custName;
        }
        public string getCustPhNo()
        {
            return _custPhNo;
        }
        public string getCustEmail()
        {
            return _custEmail;
        }
        public string getCustAddress()
        {
            return _custAddress;
        }

    }
}
