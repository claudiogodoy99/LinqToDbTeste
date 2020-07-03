using console_Linq2Db.DAL;
using console_Linq2Db.Domain;
using LinqToDB;
using LinqToDB.Data;
using System.Linq;

namespace console_Linq2Db
{
    class Program
    {
        static void Main(string[] args)
        {
            DataConnection.DefaultSettings = new DbSettings();

            using (var dbContext = new DbLinq2Db())
            {
                Insert(dbContext);
                Update(dbContext);
                Selects(dbContext);
            }
        }



        public static void Insert(DbLinq2Db dbContext)
        {
            dbContext.Insert(new Empresa
            {
                Nome = "Segunda Empresa"
            });

            dbContext.Insert(new Funcionario
            {
                Nome = "Carlos",
                Empresa_Id = 2

            });

            dbContext.Insert(new Funcionario
            {
                Nome = "Juse",
                Empresa_Id = 2

            });
        }

        public static void Update(DbLinq2Db dbContext)
        {
            dbContext.Update(new Empresa
            {
                Id = 1,
                Nome = "Primeira Empresa Update"

            });

        }


        public  static void Selects(DbLinq2Db dbContext)
        {
            var selectFuncionario = (from f in dbContext.Funcionario
                                     select f).ToList();


            var selectFuncionarioWhere = (from f in dbContext.Funcionario
                                          where f.Empresa_Id == 1
                                          orderby f.Id descending
                                          select f).ToList();



            var selectFuncionarioJoin = (from f in dbContext.Funcionario
                                         join e in dbContext.Empresa on f.Empresa_Id equals e.Id
                                         select new Funcionario
                                         {
                                             Id = f.Id,
                                             Nome = f.Nome,
                                             Empresa_Id = f.Empresa_Id,
                                             Empresa = e,
                                         }).ToList();

            var selectFuncionarioLeftJoin = (from f in dbContext.Funcionario
                                         from e in dbContext.Empresa.Where(x => x.Id == f.Empresa_Id).DefaultIfEmpty()
                                         select new Funcionario
                                         {
                                             Id = f.Id,
                                             Nome = f.Nome,
                                             Empresa_Id = f.Empresa_Id,
                                             Empresa = e,
                                         }).ToList();
        }

    }

   




}

