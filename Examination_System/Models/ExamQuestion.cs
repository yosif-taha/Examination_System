using Microsoft.EntityFrameworkCore;

namespace Examination_System.Models
{
    public class ExamQuestion : BaseModel<Guid>
    {
        public Guid ExamId { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Exam Exams { get; set; } = null!;
        public Guid QuestionId { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Question Question { get; set; } = null!;
    }
}
