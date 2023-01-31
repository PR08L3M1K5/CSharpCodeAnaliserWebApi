using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
