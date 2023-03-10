using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpCodeAnaliserWebApi.CodeAnaliser.Database.Entities
{
    public class ValidatorRuleEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Param { get; set; }
        [Column("Code_Excercise_Id")]
        public int CodeExcerciseEntityId { get; set; }
        public CodeExcerciseEntity CodeExcerciseId { get; set; }
    }
}
