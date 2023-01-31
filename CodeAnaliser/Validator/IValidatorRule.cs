using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeAnaliserWebApi.Validator
{
    interface IValidatorRule
    {
         CodeStatus Validate(string CandidateCode);
           
    }
}
