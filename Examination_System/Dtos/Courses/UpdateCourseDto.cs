namespace Examination_System.Dtos.Courses
{
    public class UpdateCourseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = null!;
        public int Hours { get; set; }
    }
}
