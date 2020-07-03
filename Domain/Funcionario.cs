
using LinqToDB.Mapping;

namespace console_Linq2Db.Domain
{
    [Table(Name = "Funcionario")]
    public class Funcionario
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "nome"), NotNull]
        public string Nome { get; set; }

        [Column(Name = "empresa_id")]
        public int? Empresa_Id { get; set; }

        [NotColumn]
        public Empresa Empresa { get; set; }
    }
}
