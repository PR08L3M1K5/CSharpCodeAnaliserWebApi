using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils;

namespace CSharpCodeAnaliserWebApi.Validator.Rules
{
    class ClassUsageRule : IValidatorRule
    {
        private string RestrictedClass;
        public ClassUsageRule(string restrictedClass) {
        this.RestrictedClass = restrictedClass;
        }
        CodeStatus IValidatorRule.Validate(string CandidateCode)
        {
            if(CandidateCode.Contains(RestrictedClass) )
                return new CodeStatus(false, "You use restricted class or method!", "You cant use: " + RestrictedClass);
            return new CodeStatus(true, "Validation complete!", null);
        }
    }
}
