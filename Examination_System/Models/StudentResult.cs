    using Microsoft.EntityFrameworkCore;

namespace Examination_System.Models
{
    public class StudentResult : BaseModel<Guid>
    {
        public Guid StudentExamId { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public StudentExam StudentExam { get; set; } = null!;
        public Guid QuestionId { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Question Question { get; set; } = null!;
        public Guid ChoiceId { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Choice Choice { get; set; } = null!;
    }
}
