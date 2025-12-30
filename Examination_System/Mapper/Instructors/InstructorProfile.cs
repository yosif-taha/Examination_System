using AutoMapper;
using Examination_System.Dtos.Courses;
using Examination_System.Models;
using Examination_System.ViewModels.Courses;

namespace Examination_System.Mapper.Instructors
{
    public class InstructorProfile : Profile
    {
        public InstructorProfile()
        {
            CreateMap<Instructor, InstructorLiteDto>()
               .ForMember(des => des.FullName, opt => opt.MapFrom(src => src.Users.FullName));
            CreateMap<InstructorLiteDto, InstructorLiteViewModel>();
        }
    }
}
