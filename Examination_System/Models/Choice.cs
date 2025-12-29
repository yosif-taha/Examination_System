using System.ComponentModel.DataAnnotations;

namespace Examination_System.Models
{
    public class Choice : BaseModel<Guid>
    {
        [Required]
        public string Text { get; set; } = null!;
        public bool IsCorrect { get; set; }
        public Guid QuestionId { get; set; }
        public Question Question { get; set; } = null!;
    }
}
