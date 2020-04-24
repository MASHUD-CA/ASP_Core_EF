using ASP_Core_EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Repository folder manage Database connections.
namespace ASP_Core_EF.Reposotory
{
    public class DB_Context:DbContext
    {
        public DB_Context(DbContextOptions<DB_Context>options):base(options)
        {
        }
        //Name should be same as Database table name
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Gender> Genders { get; set; }
    }
}
