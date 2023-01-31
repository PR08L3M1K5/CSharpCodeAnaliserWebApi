using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpCodeAnaliserWebApi.CodeAnaliser.Database.Entities
{
    public class CodeExcerciseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column("Source_Code")]
        public string SourceCode { get; set; }

        public List<TestCaseEntity> Tests { get; set; }
        public List<ValidatorRuleEntity> Validators { get; set; }

    }
}
