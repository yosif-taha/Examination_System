namespace Examination_System.Models
{
    public class Student : BaseModel<Guid>
    {
        public Guid UserId { get; set; }
        public User Users { get; set; }
        public ICollection<StudentExam> StudentExams { get; set; } = new HashSet<StudentExam>();
        public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
        public ICollection<Enrollment> Enrollments { get; set; } = new HashSet<Enrollment>();
    }
}
