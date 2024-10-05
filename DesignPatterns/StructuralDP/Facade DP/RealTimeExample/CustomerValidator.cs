using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdParty.Json.LitJson;

namespace DesignPatterns.StructuralDP.Facade_DP.RealTimeExample
{
    
    public class CustomerValidator
    {
        public Customer customerdata;

        public CustomerValidator(Customer customer) 
        {
            this.customerdata = customer;
        }

        public ValidationResult validateCustomer()
        {
            string custEmail = this.customerdata.getCustEmail();
            string custName = this.customerdata.getCustomerName();
            string custPhNo = this.customerdata.getCustPhNo();
            

            //checking if there exsists a user with the same email
            var connectionString = "mongodb+srv://sudharshan:sudharshan@mernauth.jsizlbe.mongodb.net/FacadeDP?retryWrites=true&w=majority&appName=mernauth";
            var client = new MongoClient(connectionString);

            var database = client.GetDatabase("FacadeDp");
            var collections = database.GetCollection<BsonDocument>("customerdata");

            var filter = Builders<BsonDocument>.Filter.Eq("CustomerEmail", custEmail);
            var data = collections.Find(filter).FirstOrDefault();
            if (data != null)
            {
                return new ValidationResult { Status= false,Message= "User with this emailID already exists"};
            }


            if (custPhNo == null ||  custPhNo.Length < 10)
            {
                return new ValidationResult { Status = false, Message = "Phone Number should be atleast 10 characters" };
            }



            return new ValidationResult {Status=  true,Message= "Validation Successfull"};
        }

        
    }
}
