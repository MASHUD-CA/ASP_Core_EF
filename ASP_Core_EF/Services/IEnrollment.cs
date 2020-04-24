using System;
using ASP_Core_EF.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Core_EF.Services
{
    //To get one/all Enrollment and add/remove any Enrollment
    public interface IEnrollment
    {
        IEnumerable<Enrollment> GetEnrollments { get; }
        Enrollment GetEnrollment(int? Id);

        void Add(Enrollment _Enrollment);
        void Remove(int? Id);
    }
}
