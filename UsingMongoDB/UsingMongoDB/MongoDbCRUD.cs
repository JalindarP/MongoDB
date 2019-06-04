using System;
using MongoDB.Driver;
using UsingMongoDB.Entity;

namespace UsingMongoDB
{
    public class MongoDbCRUD
    {
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;

        public MongoDbCRUD()
        {
            _client = new MongoClient("mongodb+srv://jalindar:Eurofins123@cluster0-cc9b9.mongodb.net/test?retryWrites=true&w=majority");
            _database = _client.GetDatabase("Organisation");
        }

        public void Read()
        {
            var result = _database.GetCollection<EmployeeEntity>("Employee").AsQueryable();
            Console.WriteLine(result.ToList().Count);
        }

        public void Create()
        {
            var result = _database.GetCollection<EmployeeEntity>("Employee");
            result.InsertOne(new EmployeeEntity()
            {
                FirstName = "ABC",
                LastName = "XYZ"
            });
        }
    }
}
