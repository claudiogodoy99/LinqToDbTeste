using LinqToDB.Configuration;

namespace console_Linq2Db.DAL
{
    public class ConnectionStringSettings : IConnectionStringSettings
    {
        public string ConnectionString { get; set; }

        public string Name { get; set; }

        public string ProviderName { get; set; }

        public bool IsGlobal => false;
    }
}
