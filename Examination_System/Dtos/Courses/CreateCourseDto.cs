namespace Examination_System.Dtos.Courses
{
    public class CreateCourseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hours { get; set; }
        public int InstructorId { get; set; }
        public List<int>? ExamIds { get; set; }
        public List<int>? StudentIds { get; set; }
    }
}
