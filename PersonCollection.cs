using MongoDB.Driver;

namespace Customer.Model
{
    public class PersonCollection
    {
        private IPersonContext PersonContext;

        public PersonCollection(IPersonContext personContext)
        {
            this.PersonContext = personContext;
        }

        public void OutPutPersons()
        {
            var list = PersonContext.Persons.Find<Person>
                    (p => true).ToList<Person>();

            foreach (Person person in list)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}

