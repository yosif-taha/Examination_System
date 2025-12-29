using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Examination_System.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {

        }

        public DbSet<Choice> Choices { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ExamQuestion> ExamQuestions { get; set; }
        public DbSet<StudentResult> StudentResults { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<StudentExam> StudentExams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(log => Debug.WriteLine(log),LogLevel.Information);
          //  base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var idProperty = entityType.FindProperty("Id");
                if (idProperty != null && idProperty.ClrType == typeof(Guid))
                {
                    idProperty.SetDefaultValueSql("NEWSEQUENTIALID()");
                }
            }
            base.OnModelCreating(modelBuilder);
        }


    }
}
