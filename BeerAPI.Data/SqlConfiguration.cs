namespace BeerAPI.Data
{
    public class SqlConfiguration
    {
        public SqlConfiguration(string _connectionString) => ConnectionString = _connectionString;
        public string ConnectionString { get; }
    }
}
