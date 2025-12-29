using Examination_System.Models;

namespace Examination_System.Dtos.Courses
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = null!;
        public int Hours { get; set; }
        public InstructorLiteDto Instructor { get; set; } 
        public ICollection<ExamLiteDto> Exams { get; set; } = new List<ExamLiteDto>();
        public ICollection<StudentLiteDto> Students { get; set; } = new List<StudentLiteDto>();
    }
}
