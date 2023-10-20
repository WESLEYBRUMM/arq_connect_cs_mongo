using System;
using MongoDB.Bson;
using MongoDB.Driver;

class Program
{
    static void Main()
    {
        string connectionString = "mongodb+srv://wesleyx:wes123@cluster0.3uid54z.mongodb.net/?retryWrites=true&w=majority";
        string databaseName = "wesleyx";
        MongoClient client = new MongoClient(connectionString);
        IMongoDatabase database = client.GetDatabase(databaseName);
        IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("USERS");
        var usuarios = new BsonDocument
        {
            { "nome", "Wesley Brum" },
            { "idade", 30 },
            {"local", "castelo"}
        };
        collection.InsertOne(usuarios);

        var BuscaUser = Builders<BsonDocument>.Filter.Eq("nome", "Wesley Brum");
        var resultado = collection.Find(BuscaUser).ToList();

        foreach (var consultaMongo in resultado)
        {
            Console.WriteLine(consultaMongo);
        }
    }
}
