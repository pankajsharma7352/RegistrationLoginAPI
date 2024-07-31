
using Microsoft.EntityFrameworkCore;
using StudentRegAndLogin.Data.Dbglobal;
using StudentRegAndLogin.services.StudentServices;
using StudentRegAndLogin.Services.StudentServices;

namespace StudentRegAndLogin.web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddTransient<IStudentServices, StudentServices>();
            builder.Services.AddControllers();

            builder.Services.AddDbContext<StudentContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

           

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
