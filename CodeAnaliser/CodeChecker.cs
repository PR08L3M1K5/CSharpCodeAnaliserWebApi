using CSharpCodeAnaliserWebApi.CodeAnaliser.Database.Entities;
using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils;
using CSharpCodeAnaliserWebApi.Validator;


namespace CSharpCodeAnaliserWebApi
{
  internal class CodeChecker
    {
        private CodeValidator Validator;
        private CodeTestCases TestCases;
        private string CandidateCode;
        public CodeChecker(List<ValidatorRuleEntity> validatorRuleEntities,List<TestCaseEntity> testCaseEntities,string candidateCode)
        {
            this.Validator = new CodeValidator(validatorRuleEntities);
            this.TestCases = new CodeTestCases(testCaseEntities);
            this.CandidateCode = candidateCode;
        }
        public CodeStatus RunCode()
        {
            var codeStatus = Validator.ValidateCode(CandidateCode);
            if(codeStatus.Status)
                   return this.TestCases.TestCode(CandidateCode);
            return codeStatus;
        }
    }
}
