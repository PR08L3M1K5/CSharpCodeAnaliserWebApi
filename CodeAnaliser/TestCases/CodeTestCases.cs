using CSharpCodeAnaliserWebApi.CodeAnaliser.Database.Entities;
using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils;
using CSharpCodeAnaliserWebApi.TestCases;

namespace CSharpCodeAnaliserWebApi
{
    class CodeTestCases
    {
        private List<ITestCase> TestsCases;
        public CodeTestCases(List<TestCaseEntity> testCaseEntities)
        {
            TestsCases = TestCasesFactory.GetTestCases(testCaseEntities);
        }   

        public CodeStatus TestCode(string candidateCode)
        {
            foreach (var testCase in TestsCases)
            {
                var testResult = testCase.TestCode(candidateCode);
                if(testResult.GetStatus()==false)
                {
                    return testResult;
                }
            }
            return new CodeStatus(true, "All test passed!", "Good Job!");
        }
    }
}
