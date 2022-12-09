namespace Customer
{
    public class MongoDBConfig
    {
        public string Database
        {
            get
            {
                return "Customers";
            }
        }
        public string Host { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string ConnectionString
        {
            get
            {
                return $@"mongodb://root:example@localhost:27017";
            }
        }
    }
}

