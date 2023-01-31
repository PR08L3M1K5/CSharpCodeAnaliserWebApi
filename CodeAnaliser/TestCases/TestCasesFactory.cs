
using CSharpCodeAnaliserWebApi.CodeAnaliser.Database.Entities;
using CSharpCodeAnaliserWebApi.TestCases.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
