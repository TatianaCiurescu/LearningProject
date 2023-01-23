using LearningProject.Models;
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
        public async Task<IEnumerable<School>> Get()
        {
            var schools = await _schoolRepository.GetAll();
            return schools;
        }
    }
}