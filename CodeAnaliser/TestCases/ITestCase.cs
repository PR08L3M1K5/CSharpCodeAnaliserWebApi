using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils;

namespace CSharpCodeAnaliserWebApi.TestCases
{
    internal interface ITestCase
  {       public CodeStatus TestCode(string candidateCode);
    }
}
