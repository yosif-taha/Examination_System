namespace Examination_System.ViewModels.Courses
{
    public class AddCourseViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; } = null!;
        public int Hours { get; set; }
    }
}
