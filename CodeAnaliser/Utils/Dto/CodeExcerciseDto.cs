namespace CSharpCodeAnaliserWebApi.CodeAnaliser.Utils.Dto
{
    public class CodeExcerciseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SourceCode { get;set; }
        public List<TestCaseDto> Tests { get; set; }
        public List<ValidatorRuleDto> Validators { get; set; }
    }
}
