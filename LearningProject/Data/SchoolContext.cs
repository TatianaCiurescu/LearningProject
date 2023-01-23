using Microsoft.EntityFrameworkCore;
using LearningProject.Models;

namespace LearningProject.Data

{
    public class SchoolContext: DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) 
        {
        }

        public DbSet<School> Schools { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>().ToTable("School");
        }
    }
}
