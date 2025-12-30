namespace Examination_System.ViewModels.Courses
{
    public class UpdateCourseViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = null!;
<<<<<<< HEAD
        public int? Hours { get; set; }
        public Guid InstructorId { get; set; }
=======
        public int Hours { get; set; }
>>>>>>> 524c58f25cbde85a2f6b51de925dd8b5791e2cb3
    }
}
