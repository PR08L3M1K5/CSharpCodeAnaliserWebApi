using AutoMapper;
using CSharpCodeAnaliserWebApi.CodeAnaliser.Database.Entities;
using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils;
using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils.Dto;
using Microsoft.EntityFrameworkCore;

namespace CSharpCodeAnaliserWebApi
{
    internal class CodeValidatorFacade
    {
        private readonly PostgresDatabase _context;
        private IMapper _mapper;

        public CodeValidatorFacade()
        {
            _context = new PostgresDatabase();
            _mapper = ObjectMapper.GetMapper();
        }
        public CodeStatus CheckCode(int excerciseId,string candidateCode)
        {
            var CodeExcercise = _context.Code_Excercise.Where(c=>c.Id==excerciseId).Include(c=>c.Validators).Include(c=>c.Tests).First();
            CodeChecker codeAnalisier = new CodeChecker(CodeExcercise.Validators, CodeExcercise.Tests,candidateCode);
            return  codeAnalisier.RunCode();
        }

        public void AddExcercise(CodeExcerciseDto codeExcercise)
        {
            var excercise = _mapper.Map<CodeExcerciseEntity>(codeExcercise);
            _context.Code_Excercise.Add(excercise);
           _context.SaveChanges();
        }

        public CandidateExerciseDto GetCandidateExercise(int id)
        {
            return _mapper.Map<CandidateExerciseDto>(_context.Code_Excercise.Where(_c => _c.Id==id).First());
        }
    }
}
