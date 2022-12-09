using System;
using MongoDB.Driver;

namespace Customer.Model
{
    public interface IPersonContext
    {
        IMongoCollection<Person> Persons { get; }
    }
}

