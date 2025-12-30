using AutoMapper;
using Examination_System.Contracts;
using Examination_System.Data;
using Examination_System.Dtos.Courses;
using Examination_System.Models;
using Examination_System.Services;
using Examination_System.ViewModels.Courses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Examination_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController(ICourseService _courseService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<GetAllViewModel>> GetAll()
        {

            var courseDto = await _courseService.GetAllCoursesAsync();
            var result = _mapper.Map<IEnumerable<GetAllViewModel>>(courseDto);
            return result;
        }

        [HttpGet("{id}")]
        public async Task<GetAllViewModel> GetCourseById(Guid id)
        {
            var courseDto = await _courseService.GetCourseAsync(id);
            var result = _mapper.Map<GetAllViewModel>(courseDto);
            return result;
        }

        [HttpPost]
        public async Task<string> AddCourse([FromBody] AddCourseViewModel addCourse)
        {
            if (addCourse == null) throw new Exception("Invalid Course Data");
            var courseDto = _mapper.Map<CreateCourseDto>(addCourse);
            var result = await _courseService.AddCourseAsync(courseDto);
            if (result != "Success") throw new Exception("Could not create the course");
            return "Course Created";
        }

        [HttpPut]
        public async Task<string> UpdateCourse([FromBody] UpdateCourseViewModel updateCourse)
        {
            if (updateCourse == null) throw new Exception("Invalid Course Data");
            var courseDto = _mapper.Map<UpdateCourseDto>(updateCourse);
            var result = await _courseService.UpdateCourseAsync(courseDto);
            if (result != "Success") throw new Exception("Could not Update the course");
            return "Course Updated";
        }

        [HttpDelete("{id}")]
        public async Task<string> UpdateCourse(Guid id)
        {
            if (id == null) throw new Exception("Invalid Course Data");  
            var result = await _courseService.DeleteCourseAsync(id);
            if (!result) throw new Exception("Could not Delete the course");
            return "Course Deleted";
        }

        

    }
}
