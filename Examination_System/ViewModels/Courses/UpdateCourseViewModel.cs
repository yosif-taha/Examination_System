namespace Examination_System.ViewModels.Courses
{
    public class UpdateCourseViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = null!;
        public int Hours { get; set; }
    }
}
