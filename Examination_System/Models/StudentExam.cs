using Microsoft.EntityFrameworkCore;

namespace Examination_System.Models
{
    public class StudentExam : BaseModel<Guid>
    {
        public Guid StudentId { get; set; }
        public Guid ExamId { get; set; }
        public decimal Score { get; set; }
        public DateTime SubmissionTime { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Student Student { get; set; } = null!;
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Exam Exam { get; set; } = null!;

        public ICollection<StudentResult> StudentResults{ get; set; } = new List<StudentResult>();
    }
}
