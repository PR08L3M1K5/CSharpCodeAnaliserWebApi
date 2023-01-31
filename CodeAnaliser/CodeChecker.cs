using CSharpCodeAnaliserWebApi.CodeAnaliser.Database.Entities;
using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils;
using CSharpCodeAnaliserWebApi.Validator;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using System.Collections;


namespace CSharpCodeAnaliserWebApi
{
    internal class CodeChecker
    {
        private CodeValidator validator;
        private CodeTestCases codeTestCases;
        private string CandidateCode;
        public CodeChecker(List<ValidatorRuleEntity> validatorRuleEntities,List<TestCaseEntity> testCaseEntities,string candidateCode)
        {
            this.validator = new CodeValidator(validatorRuleEntities);
            this.codeTestCases = new CodeTestCases(testCaseEntities);
            this.CandidateCode = candidateCode;
        }

        public CodeStatus RunCode()
        {
            var codeStatus = validator.ValidateCode(CandidateCode);
            if(codeStatus.Status)
                   return this.codeTestCases.TestCode(CandidateCode);
            return codeStatus;
        }
        
    }
}
