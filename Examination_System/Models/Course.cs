using System.Collections;

namespace Examination_System.Models
{
    public class Course : BaseModel<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; } = null!;
        public int Hours { get; set; }
        public Guid InstructorId { get; set; }
        public Instructor Instructor { get; set; } = null!;
        public ICollection<Exam> Exams { get; set; } = new List<Exam>();
        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public ICollection<Enrollment> Enrollments { get; set; } = new HashSet<Enrollment>();


    }
}
