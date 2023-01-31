using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeAnaliserWebApi.TestCases
{
    internal interface ITestCase
    {
        public CodeStatus TestCode(string candidateCode);
    }
}
