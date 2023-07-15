namespace Coupling
{
    // ***** Example of Tight Coupling - (start) *****
    class CustomerRepository
    {
        private readonly Database _database;

        public CustomerRepository(Database database)
        {
            _database = database;
        }

        public void Add(string CustomerName)
        {
            _database.AddRow("Customer", CustomerName);
        }
    }

    class Database
    {
        public void AddRow(string table, string value)
        {
            Console.WriteLine($"Table: {table}, Value: {value}");
        }
    }
    // ***** Example of Tight Coupling - (end) *****

    // ***** Example of Loose Coupling - (start) *****
    class CustomerRepository2
    {
        private readonly IDatabase _database;

        public CustomerRepository2(IDatabase database)
        {
            _database = database;
        }

        public void Add(string customerName)
        {
            _database.AddRow("Customer", customerName);
        }
    }

    interface IDatabase
    {
        void AddRow(string table, string value);
    }

    class Database2 : IDatabase
    {
        public void AddRow(string table, string value)
        {
            Console.WriteLine($"Table: {table}, Value: {value}");
        }
    } 
    // ***** Example of Loose Coupling - (end) *****
}
