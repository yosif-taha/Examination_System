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
    public class CourseController : ControllerBase
    {
        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //  var resultDto = await _courseService.GetAllAsync();
        //  var result =  _mapper.Map<IEnumerable<GetAllViewModel>>(resultDto);
        //    if (result is null) throw new Exception("Data Not Found");
        //    return Ok(result);
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //   var resultDto = await _courseService.GetByIdAsync(id);
        //   var result =  _mapper.Map<GetAllViewModel>(resultDto);
        //    if (result is null) throw new Exception("Invalid Mapping");
        //    return Ok(result);
        //}

        

    }
}
