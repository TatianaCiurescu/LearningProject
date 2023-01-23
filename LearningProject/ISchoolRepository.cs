using LearningProject.Models;

namespace LearningProject
{
    public interface ISchoolRepository
    {
        Task<IEnumerable<School>> GetAll();
    }
}
