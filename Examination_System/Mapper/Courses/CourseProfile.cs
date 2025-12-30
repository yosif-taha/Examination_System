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
<<<<<<< HEAD
<<<<<<< Updated upstream
         

           
=======
=======
>>>>>>> 524c58f25cbde85a2f6b51de925dd8b5791e2cb3
            CreateMap<Course, CourseDto>();
            CreateMap<CourseDto,GetAllViewModel>();
            CreateMap<AddCourseViewModel,CreateCourseDto>();
            CreateMap<CreateCourseDto, Course>();
<<<<<<< HEAD
                
            CreateMap<UpdateCourseViewModel, UpdateCourseDto>();
            CreateMap<UpdateCourseDto, Course>();

>>>>>>> Stashed changes
=======
            CreateMap<UpdateCourseViewModel, UpdateCourseDto>();
            CreateMap<UpdateCourseDto, Course>();
   
>>>>>>> 524c58f25cbde85a2f6b51de925dd8b5791e2cb3
        }
    }
}
