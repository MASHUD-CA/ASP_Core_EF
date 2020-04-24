using ASP_Core_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Core_EF.Services
{
    //To get one/all student and add/remove any student
    public interface IStudent
    {
        IEnumerable<Student> GetStudents { get; }
        Student GetStudent(int? Id);

        void Add(Student _Student);
        void Remove(int? Id);
    }
}

