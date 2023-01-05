using Microsoft.AspNetCore.Mvc;

namespace LearningProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolRepository _schoolRepository;
        public SchoolController(ISchoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }


        [HttpGet]      
        public IEnumerable<School> Get()
        {
            var schools = _schoolRepository.GetAll();
            return schools;
        }
    }
}