using System.ComponentModel.DataAnnotations;

namespace LearningProject.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string SchoolName { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string City { get; set; }

    }
}
