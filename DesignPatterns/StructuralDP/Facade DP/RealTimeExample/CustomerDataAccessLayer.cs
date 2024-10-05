using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDP.Facade_DP.RealTimeExample
{
    public class CustomerDataAccessLayer
    {
        public bool SaveData(Customer customer)
        {
            try
            {

                var connectionString = "mongodb+srv://sudharshan:sudharshan@mernauth.jsizlbe.mongodb.net/FacadeDP?retryWrites=true&w=majority&appName=mernauth";
                var client = new MongoClient(connectionString);

                var database = client.GetDatabase("FacadeDp");
                var collections = database.GetCollection<BsonDocument>("customerdata");

                var document = new BsonDocument
            {
                {"CustomerName",customer.getCustomerName() },
                {"CustomerphoneNumber",customer.getCustPhNo() },
                {"CustomerEmail",customer.getCustEmail() },
                {"CustomerAddress",customer.getCustAddress()}
            };


                collections.InsertOne(document);

                Console.WriteLine("Customer data saved in MongoDB");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
