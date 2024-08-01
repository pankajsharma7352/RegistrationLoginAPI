using StudentRegAndLogin.models.Models;
using StudentRegAndLogin.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegAndLogin.Services.StudentServices
{
    public interface IStudentServices
    {
        
        Task<Student> RegisterStudentAsync(StudentDTO student);
        Task<Student> LoginStudentAsync(string email, string password);
    }
}
