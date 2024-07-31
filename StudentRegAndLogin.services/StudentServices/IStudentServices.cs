using StudentRegAndLogin.models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegAndLogin.Services.StudentServices
{
    public interface IStudentServices
    {
        
        Task<Student> RegisterStudentAsync(Student student);
        Task<Student> LoginStudentAsync(string email, string password);
    }
}
