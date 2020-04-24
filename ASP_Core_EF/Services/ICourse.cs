using ASP_Core_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Core_EF.Services
{
    //To get one/all Course and add/remove any Course
    public interface ICourse
    {
        IEnumerable<Course> GetCourses { get; }
        Course GetCourse(int? Id);

        void Add(Course _Course);
        void Remove(int? Id);

    }
}
