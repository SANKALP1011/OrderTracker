using MongoDB.Driver;

namespace OrderTracker.Service
{
    public class DatabaseService
    {
        private readonly IMongoDatabase _database;
        public DatabaseService(string ConnectionString, string DatabaseName)
        {
            var client = new MongoClient(ConnectionString);
            _database = client.GetDatabase(DatabaseName);
        }
        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }
    }
}

