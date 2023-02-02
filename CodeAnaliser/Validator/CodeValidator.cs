using CSharpCodeAnaliserWebApi.CodeAnaliser.Database.Entities;
using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils;

namespace CSharpCodeAnaliserWebApi.Validator
{
    class CodeValidator
    {
        private  List<IValidatorRule> ValidatorRules;
        public CodeValidator(List<ValidatorRuleEntity>  validatorRuleEntities) {
            this.ValidatorRules = ValidatorRuleFactory.GetValidatorRules(validatorRuleEntities);
        }

        public CodeStatus ValidateCode(string candidateCode)
        { 
            foreach (var validatorRule in  ValidatorRules)
            {
               var result = validatorRule.Validate(candidateCode);
                if (result.GetStatus()==false)
                {
                   return result;
                }
            }
            return new CodeStatus(true, "Validation complete!", null);
        }
    }
}
