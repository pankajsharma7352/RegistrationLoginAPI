using Microsoft.EntityFrameworkCore;
using StudentRegAndLogin.Data.Dbglobal;
using StudentRegAndLogin.models.Models;
using StudentRegAndLogin.Services.StudentServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegAndLogin.services.StudentServices
{
    public class StudentServices : IStudentServices
    {
        private readonly StudentContext _context;

        public StudentServices(StudentContext context)
        {
            _context = context;
        }

       

        public async Task<Student> RegisterStudentAsync(Student student)
        {
            if (student.Password == student.ConfirmPassword)
            {
                _context.Students.Add(student);
                await _context.SaveChangesAsync();
      
            }
            return student;
        }

        public async Task<Student> LoginStudentAsync(string email, string password)
        {
            return await _context.Students.FirstOrDefaultAsync(s => s.Email == email && s.Password == password);
        }
    }
}
