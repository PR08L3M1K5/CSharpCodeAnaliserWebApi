using CSharpCodeAnaliserWebApi.CodeAnaliser.Database.Entities;
using CSharpCodeAnaliserWebApi.TestCases.Tests;

namespace CSharpCodeAnaliserWebApi.TestCases
{
    class TestCasesFactory
    {
        public static List<ITestCase> GetTestCases(List<TestCaseEntity> testCaseEntities) {
            var testCases = new List<ITestCase>();
                foreach (TestCaseEntity testCaseEntity in testCaseEntities) {
                    switch(testCaseEntity.Name) {
                    case "VARIABLE_TEST":
                        testCases.Add(new VariableTestCase(testCaseEntity.Input,testCaseEntity.Output)); break;
                    }        
                }
            return testCases;    
        }        
    }
}
