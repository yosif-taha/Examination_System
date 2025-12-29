using Microsoft.EntityFrameworkCore;

namespace Examination_System.Models
{
    public class StudentCourse : BaseModel<Guid>
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Student Student { get; set; } = null!;
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Course Course { get; set; } = null!;

    }
}
