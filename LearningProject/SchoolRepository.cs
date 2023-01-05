
namespace LearningProject
{
    public class SchoolRepository : ISchoolRepository
    {
        private static readonly string[] Classes = new[]
        {
        "Math", "Science","Arts", "English", "Foreign Languages", "Philosophy", "Music"
        };

        private static readonly string[] Teachers = new[]
        {
            "Victor", "Hugo", "Andrew", "Anna", "Margaret", "Elisabeth", "Ambrose"
        };

        public IEnumerable<School> GetAll()
        {
            return Enumerable.Range(1, 3).Select(index => new School
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                NumberOfStudents = Random.Shared.Next(0, 30),
                Grade = Random.Shared.Next(1, 10),
                Teacher = Teachers[Random.Shared.Next(Teachers.Length)],
                Class = Classes[Random.Shared.Next(Classes.Length)]
            })
           .ToArray();
        }
    }
}
