using AutoMapper;
using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils;
using CSharpCodeAnaliserWebApi.CodeAnaliser.Utils.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CSharpCodeAnaliserWebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CandidateExerciseController : ControllerBase
    {
        private readonly CodeValidatorFacade CodeValidatorFacade;
        public CandidateExerciseController(PostgresDatabase context, IMapper mapper)
        {
            CodeValidatorFacade = new CodeValidatorFacade();
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<CandidateExerciseDto> GetExercise(int id)
        {
            return Ok(CodeValidatorFacade.GetCandidateExercise(id));
        }

        [HttpGet("CodeResult")]
        public ActionResult<CodeStatus> GetCodeResult(int exerciseId, string candidateCode)
        {
            return Ok(CodeValidatorFacade.CheckCode(exerciseId, candidateCode));
        }

        [HttpPost(Name = "AddExcercise")]
        public void  AddExcercise(CodeExcerciseDto codeExcerciseDto)
        {

            CodeValidatorFacade.AddExcercise(codeExcerciseDto);
        }
    }
}
