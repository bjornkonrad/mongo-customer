using System;
using Customer.Model;

namespace Customer.Repository
{
    public interface IPersonRepository
    {   
        Task<IEnumerable<Person>> GetAllPersons();

        Task<Person> GetPerson(long id);

        Task Create(Person person);

        Task<bool> Update(Person person);
    }
}

