using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
