using System;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Customer.Model
{
    [BsonIgnoreExtraElements]
    public class Address
    {
        public Address(string street, string floor, string postalCode, string city, string country)
        {
            Street = street;
            Floor = floor;
            PostalCode = postalCode;
            City = city;
            Country = country;
        }

        public string Street { get; set; }
        public string Floor { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        [BsonIgnoreIfNull]
        public string? State { get; set; }
        [BsonIgnoreIfNull]
        public string? Municipality { get; set; }
        [BsonIgnoreIfNull]
        public string? Province { get; set; }
        [BsonIgnoreIfNull]
        public string? County { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Address");
            stringBuilder.AppendLine($"\tStreet: {this.Street}");
            stringBuilder.AppendLine($"\tFloor: {this.Floor}");
            stringBuilder.AppendLine($"\tPostal code: {this.PostalCode}");
            stringBuilder.AppendLine($"\tCity: {this.City}");
            stringBuilder.AppendLine($"\tCountry: {this.Country}");

            if (!string.IsNullOrEmpty(this.State)) { stringBuilder.AppendLine($"\tState: {this.State}"); }
            if (!string.IsNullOrEmpty(this.Municipality)) { stringBuilder.AppendLine($"\tMunicipality: {this.Municipality}"); }
            if (!string.IsNullOrEmpty(this.Province)) { stringBuilder.AppendLine($"\tProvince: {this.Province}"); }
            if (!string.IsNullOrEmpty(this.County)) { stringBuilder.AppendLine($"\tCounty: {this.County}"); }


            return stringBuilder.ToString();

        }
    }
}
