
using Examination_System.Contracts;
using Examination_System.Data;
using Examination_System.Mapper.Courses;
using Examination_System.Repository;
using Examination_System.Services;
using Examination_System.UnitofWork;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Examination_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddAutoMapper(m => m.AddProfile(new CourseProfile()));
          
            // builder.Services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
              builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
              builder.Services.AddScoped<ICourseService, CourseService>();
           
            builder.Services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
