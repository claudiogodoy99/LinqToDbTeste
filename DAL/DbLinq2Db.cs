using console_Linq2Db.Domain;
using LinqToDB;
using LinqToDB.Data;

namespace console_Linq2Db.DAL
{
    public class DbLinq2Db : DataConnection
    {
        public DbLinq2Db() : base("LinqToDbTeste") {
            
        }

        public ITable<Empresa> Empresa => GetTable<Empresa>();
        public ITable<Funcionario> Funcionario => GetTable<Funcionario>();

    }
}
