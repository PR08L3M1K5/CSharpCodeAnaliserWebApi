using System.Drawing;

namespace CSharpCodeAnaliserWebApi.CodeAnaliser.Utils.Dto
{
    public class TestCaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
    }
}