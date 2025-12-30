using AutoMapper;
using Examination_System.Dtos.Courses;
using Examination_System.Models;
using Examination_System.ViewModels.Courses;

namespace Examination_System.Mapper.Courses
{
    public class CourseProfile : Profile
    {
        public CourseProfile() 
        {
            CreateMap<Course, CourseDto>();
            CreateMap<CourseDto,GetAllViewModel>();
            CreateMap<AddCourseViewModel,CreateCourseDto>();
            CreateMap<CreateCourseDto, Course>();
            CreateMap<UpdateCourseViewModel, UpdateCourseDto>();
            CreateMap<UpdateCourseDto, Course>();
   
        }
    }
}
