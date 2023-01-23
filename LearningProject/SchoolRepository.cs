
using LearningProject.Data;
using LearningProject.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningProject
{
    public class SchoolRepository : ISchoolRepository
    {
      
        private readonly SchoolContext _context;

        public SchoolRepository(SchoolContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<School>> GetAll()
        {
            var data =await _context.Schools.ToListAsync();
            return data;
        }
    }
}
