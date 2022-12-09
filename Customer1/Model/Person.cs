using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Customer.Model
{
    [BsonIgnoreExtraElements]
    public class Person
    {
        public Person(string name, Address address)
        {
            Name = name;
            Addresses = new List<Address> { address };
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Addresses")]
        public List<Address> Addresses { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"PersonID: {this.Id} - Person Name: {this.Name}");

            stringBuilder.AppendLine("Addresses:");

            foreach (var address in Addresses)
            {
                stringBuilder.Append(address.ToString());
            }

            return stringBuilder.ToString();
        }
        
    }
}

