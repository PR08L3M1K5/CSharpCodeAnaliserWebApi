
using CSharpCodeAnaliserWebApi.CodeAnaliser.Database.Entities;
using CSharpCodeAnaliserWebApi.Validator;
using CSharpCodeAnaliserWebApi.Validator.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeAnaliserWebApi
{
    class ValidatorRuleFactory
    {
        public static List<IValidatorRule> GetValidatorRules(List<ValidatorRuleEntity> validatorRuleEntities)
        {
            List<IValidatorRule> validatorRules= new List<IValidatorRule>();
            foreach(ValidatorRuleEntity entity in validatorRuleEntities)
            {
                switch(entity.Name)
                {
                    case "CODE_LENGTH_RULE":
                        validatorRules.Add(new CodeLenghtRule(entity.Param)); break;
                    case "CLASS_USAGE_RULE":
                        validatorRules.Add(new ClassUsageRule(entity.Param)); break;
                }
            }
            return validatorRules;
        }

    }
}
