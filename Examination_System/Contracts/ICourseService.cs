using Examination_System.Controllers;
using Examination_System.Dtos.Courses;
using Examination_System.Models;

namespace Examination_System.Contracts
{
    public interface ICourseService
    {

        Task<IEnumerable<CourseDto>> GetAllCoursesAsync();
        Task<CourseDto> GetCourseAsync(Guid id);
        Task<string> AddCourseAsync(CreateCourseDto courseDto);
        Task<string> UpdateCourseAsync(UpdateCourseDto courseDto);
        Task<bool> DeleteCourseAsync(Guid id);

    }
}
