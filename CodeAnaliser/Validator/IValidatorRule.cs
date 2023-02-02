using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils;

namespace CSharpCodeAnaliserWebApi.Validator
{
    interface IValidatorRule
    {
        CodeStatus Validate(string CandidateCode);        
    }
}
