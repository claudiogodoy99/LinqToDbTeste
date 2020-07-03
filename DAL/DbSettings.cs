using LinqToDB.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace console_Linq2Db.DAL
{
    public class DbSettings : ILinqToDBSettings
    {
        public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => "SqlServer";

        public string DefaultDataProvider => "SqlServer";

        public IEnumerable<IConnectionStringSettings> ConnectionStrings {
            get {
                yield return new ConnectionStringSettings
                {
                    ConnectionString = @"Server = LAPTOP-5HMS9AV4\SQLEXPRESS;DataBase = LinqToDbTeste;Trusted_Connection = True;",
                    ProviderName = DefaultDataProvider,
                    Name = "LinqToDbTeste"
                };
            }
            
        }
    }
}
