using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentRegAndLogin.models.Models;
using StudentRegAndLogin.Models.Models;
using StudentRegAndLogin.services.StudentServices;
using StudentRegAndLogin.Services.StudentServices;

namespace StudentRegAndLogin.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentServicesController : ControllerBase
    {
        private readonly IStudentServices _studentServices;

        public StudentServicesController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        [HttpPost("register")]
        public async Task<Student> RegisterStudent(StudentDTO student)
        {
                return await _studentServices.RegisterStudentAsync(student);     
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<Student>> LoginStudent(string email, string password)
        {
            var student = await _studentServices.LoginStudentAsync(email, password);
            if (student == null)
            {
                return Unauthorized();
            }
            return Ok(student);
        }
    }
}
