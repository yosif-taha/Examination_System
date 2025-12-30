using AutoMapper;
using AutoMapper.QueryableExtensions;
using Examination_System.Contracts;
using Examination_System.Data;
using Examination_System.Dtos.Courses;
using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Examination_System.Services
{
    public class CourseService(IUnitOfWork _unitOfWork, IMapper _mapper) : ICourseService
    {
        public async Task<IEnumerable<CourseDto>> GetAllCoursesAsync()
        {
           var query =  _unitOfWork.GetRepository<Guid,Course>().GetAll();
            if (query == null) throw new Exception("No Courses Found");
            var result = query.ProjectTo<CourseDto>(_mapper.ConfigurationProvider).ToList();
              return result;
        }
        public async Task<CourseDto> GetCourseAsync(Guid id)
        {
            var course =  _unitOfWork.GetRepository<Guid,Course>().GetAll().Where(e => e.Id == id);
            if (course == null) throw new Exception("No Courses Found");
            var result = course.ProjectTo<CourseDto>(_mapper.ConfigurationProvider).FirstOrDefault();
            return result;
        }
        public async Task<string> AddCourseAsync(CreateCourseDto courseDto)
        {
          var course = _mapper.Map<Course>(courseDto);
            await _unitOfWork.GetRepository<Guid,Course>().AddAsync(course);
            var count = await _unitOfWork.SaveChangeAsync();
            if (count == 0) throw new Exception("Failed to add Course");
            return "Success";

        }
        public async Task<string> UpdateCourseAsync(UpdateCourseDto courseDto)
        {
            var course = _unitOfWork.GetRepository<Guid, Course>().GetAll().Where(e => e.Id == courseDto.Id);
            if (course == null) throw new Exception("No Courses Found");
            var updateCourse = _mapper.Map<Course>(courseDto);
             _unitOfWork.GetRepository<Guid, Course>().Update(updateCourse);
            var count = await _unitOfWork.SaveChangeAsync();
            if (count == 0) throw new Exception("Failed to update Course");
            return "Success";
        }
        public async Task<bool> DeleteCourseAsync(Guid id)
        {
            await _unitOfWork.GetRepository<Guid, Course>().SoftDeleteAsync(id);
            var count = await _unitOfWork.SaveChangeAsync();
            if (count == 0) throw new Exception("Failed to delete Course");
            return true;
        }


    }
}
