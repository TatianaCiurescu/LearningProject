using Microsoft.EntityFrameworkCore;

namespace LearningProject.Models
{
    [Keyless]
    public class School
    {
        public DateTime Date { get; set; }

        public int NumberOfStudents { get; set; }

        public string Grade { get; set; }

        public string? Teacher { get; set; }

        public string? Class { get; set; }


    }
}