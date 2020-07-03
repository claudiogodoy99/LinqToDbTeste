using LinqToDB.Mapping;

namespace console_Linq2Db.Domain
{
    [Table(Name = "Empresa")]
    public class Empresa
    {
        [PrimaryKey,Identity]
        public int Id { get; set; }

        [Column(Name = "nome"), NotNull]
        public string Nome { get; set; }
    }
}
