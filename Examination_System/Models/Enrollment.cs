using Microsoft.EntityFrameworkCore;

namespace Examination_System.Models
{
    public class Enrollment : BaseModel<Guid>
    {
        public Guid StudentsId { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Student Students { get; set; }
        public Guid CoursesId { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Course Courses { get; set; }
        public string Status { get; set; }
    }
}
