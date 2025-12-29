using Examination_System.Data;
using Examination_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Examination_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        //[HttpPost]
        //public bool AddExam(Exam exam)
        //{
        //    Context context = new Context();
        //    context.Exams.Add(exam);
        //    context.SaveChanges();
        //    return true;
        //}

        //[HttpGet]
        //public List<Exam> GetAll()
        //{
        //    Context context = new Context();
        //    var result = context.Exams.ToList();
        //    return result;
        //}

        //[HttpGet("{id}")]
        //public Exam GetById(int id)
        //{
        //    Context context = new Context();
        //    var result = context.Exams.FirstOrDefault(C => C.Id == id);
        //    return result;
        //}

        //[HttpDelete]
        //public async Task<bool> DeleteExam(int id)
        //{
        //    Context context = new Context();
        //    var exam = await context.Exams.FirstOrDefaultAsync(E => E.Id ==id);
        //    context.Exams.Remove(exam);
        //    await context.SaveChangesAsync();
        //    return true;
        //}
    }
}
