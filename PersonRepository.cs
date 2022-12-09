using System;
using Customer.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Customer.Repository
{
	public class PersonRepository
	{
        private readonly IPersonContext _context;
        public PersonRepository(IPersonContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Person>> GetAllPersons()
        {
            return await _context
                            .Persons
                            .Find(_ => true)
                            .ToListAsync();
        }
        public Task<Person> GetTodo(string id)
        {
            FilterDefinition<Person> filter = Builders<Person>.Filter.Eq(m => m.Id, id);
            return _context
                    .Persons
                    .Find(filter)
                    .FirstOrDefaultAsync();
        }
        public async Task Create(Person person)
        {
            await _context.Persons.InsertOneAsync(person);
        }
        public async Task<bool> Update(Person todo)
        {
            ReplaceOneResult updateResult =
                await _context
                        .Persons
                        .ReplaceOneAsync(
                            filter: g => g.Id == todo.Id,
                            replacement: todo);
            return updateResult.IsAcknowledged
                    && updateResult.ModifiedCount > 0;
        }
    }
}

