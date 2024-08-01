using Microsoft.EntityFrameworkCore;
using StudentRegAndLogin.Data.Dbglobal;
using StudentRegAndLogin.models.Models;
using StudentRegAndLogin.Models.Models;
using StudentRegAndLogin.Services.StudentServices;
using AutoMapper;


namespace StudentRegAndLogin.services.StudentServices
{
    public class StudentServices : IStudentServices
    {
        private readonly StudentContext _context;
        private readonly IMapper _mapper;

        public StudentServices(StudentContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }




        //public async Task<Student> RegisterStudentAsync(StudentDTO student)
        //{
        //    Student s = new Student();
        //    s.Name = student.Name;
        //    s.Email = student.Email;
        //    s.Password = student.Password;
        //    s.Address = student.Address;
        //    s.Age = student.Age;

        //    _context.Students.Add(s);
        //    await _context.SaveChangesAsync();
        //    return s;
        //}

        public async Task<Student> RegisterStudentAsync(StudentDTO student)
        {
            var stud = _mapper.Map<Student>(student);
            _context.Students.Add(stud);
            await _context.SaveChangesAsync();
            return stud;
        }

        public async Task<Student> LoginStudentAsync(string email, string password)
        {
            return await _context.Students.FirstOrDefaultAsync(s => s.Email == email && s.Password == password);
        }

    }
}
