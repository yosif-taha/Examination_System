using Examination_System.Models.Enum;

namespace Examination_System.Models
{
    public class Question : BaseModel<Guid>
    {
        public string Text  { get; set; } = null!;
        public QusetionLevel Level { get; set; }
        public Guid InstructorId { get; set; }
        public Instructor Instructor { get; set; } = null!;
        public ICollection<Choice> Choices { get; set; } = new List<Choice>();
        public ICollection<ExamQuestion> ExamQuestions { get; set; } = new List<ExamQuestion>();

    }
}
