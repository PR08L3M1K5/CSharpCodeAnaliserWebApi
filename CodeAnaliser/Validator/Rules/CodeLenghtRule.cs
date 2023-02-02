using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils;

namespace CSharpCodeAnaliserWebApi.Validator.Rules
{
    class CodeLenghtRule: IValidatorRule
    {
        private int CodeLenght;
        public CodeLenghtRule(string codeLenght)
        {
            CodeLenght= int.Parse(codeLenght); 
        }
        public CodeStatus Validate(string CandidateCode)
        {
            if (CandidateCode.Length > CodeLenght)
                return new CodeStatus(false, "Your code is too long", "Should be under :" + CodeLenght.ToString());
            return new CodeStatus(true, "Validation complete!", null);
        }
    }
}
