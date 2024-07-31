using Microsoft.EntityFrameworkCore;
using StudentRegAndLogin.models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegAndLogin.Data.Dbglobal
{
    public class StudentContext: DbContext 
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}
