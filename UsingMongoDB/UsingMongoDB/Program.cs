using System;

namespace UsingMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoDbCRUD obj = new MongoDbCRUD();
            obj.Read();
            obj.Create();
            obj.Read();
            Console.WriteLine("Hello World!");
        }
    }
}
