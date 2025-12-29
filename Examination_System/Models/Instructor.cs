namespace Examination_System.Models
{
    public class Instructor : BaseModel<Guid>
    {
        public Guid UserId { get; set; }
        public User Users { get; set; }
        public ICollection<Question> Questions { get; set; } = new List<Question>();
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
