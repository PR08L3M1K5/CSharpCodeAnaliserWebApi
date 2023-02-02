using AutoMapper;
using CSharpCodeAnaliserWebApi.CodeAnaliser.Database.Entities;
using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils.Dto;

namespace CSharpCodeAnaliserWebApi.CodeAnaliser.Utils
{
    public  class ObjectMapper
    {
        public static IMapper GetMapper() {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CodeExcerciseDto, CodeExcerciseEntity>();
                cfg.CreateMap<CodeExcerciseEntity, CandidateExerciseDto>();
                cfg.CreateMap<TestCaseDto, TestCaseEntity>();
                cfg.CreateMap<ValidatorRuleDto, ValidatorRuleEntity>();
            }).CreateMapper();  
        }
    }
}
