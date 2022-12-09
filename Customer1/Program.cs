using System.Xml.Linq;
using Customer.Model;
using Customer.Repository;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var context = new PersonContext(new Customer.MongoDBConfig());
        var collection = new PersonCollection(context);

        //var usAddress = new Address("Same as Susan", "2nd", "12345", "Vegas", "US of A");
        //usAddress.State = "Nevada";

        //var ukAddress = new Address("Bromyard road", "2nd", "12345", "Worcester", "UK");
        //ukAddress.County = "Worcestershire";

        //var person = new Person("Luca", usAddress);
        //person.Addresses.Add(ukAddress);

        var seAddress = new Address("Sköldgatan 5", "6:e", "11863", "Stockholm", "Sverige");
        seAddress.Municipality = "Stockholm";

        var person = new Person("Min granne", seAddress);
        var repository = new PersonRepository(context);
        await repository.Create(person);

        collection.OutPutPersons();

        Console.WriteLine("Hello World!");
    }
}