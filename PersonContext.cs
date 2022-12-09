using MongoDB.Driver;

namespace Customer.Model
{
    public class PersonContext : IPersonContext
    {
        private readonly IMongoDatabase _db;
        public PersonContext(MongoDBConfig config)
        {
            var client = new MongoClient(config.ConnectionString);
            _db = client.GetDatabase(config.Database);
        }
        public IMongoCollection<Person> Persons => _db.GetCollection<Person>("Persons");
    }
}

