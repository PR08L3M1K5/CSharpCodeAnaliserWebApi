using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using System.Collections;
using System.Text;

namespace CSharpCodeAnaliserWebApi.TestCases.Tests
{
    public class VariableTestCase : ITestCase
    {
        private string[] Output;
        private string Input;
        public VariableTestCase(string input,string output)
        {
            Output = output.Trim().Split(';');
            Input = input;
        }

        public CodeStatus TestCode(string candidateCode) 
        {
            try
            {
                var result = CSharpScript.EvaluateAsync(BuildCode(candidateCode)).Result;
                return ChceckCodeResult(result);
                
            }
            catch(Exception ex)
            {
                return new CodeStatus(false, "Compilator exception!", ex.Message.ToString());
            }
           
        }
        private string BuildCode(string candidateCode)
        {
            StringBuilder code = new StringBuilder();
            code.Append("using System;");
            code.AppendLine("using System.Collections;");
            code.AppendLine(Input);
            code.AppendLine(candidateCode);
            return code.ToString();

        }

        private CodeStatus ChceckCodeResult(Object result)
        {
            if (result.GetType().IsArray || result.GetType().IsGenericType)
            {
                string[] arr = ((IEnumerable)result).Cast<object>().Select(x => x.ToString()).ToArray();
                if (arr.SequenceEqual(Output))
                    return new CodeStatus(true, "All test passed!", "Good Job!");
            }
            else
            {
                if (result.ToString().Equals(Output.Single()))
                    return new CodeStatus(true, "All test passed!", "Good Job!");

            }
            return new CodeStatus(false, "Test failed!", "Should be: " + PrintTable());
        }

        private string PrintTable()
        {
            return string.Join("; ", Output);
        }
    }
}
