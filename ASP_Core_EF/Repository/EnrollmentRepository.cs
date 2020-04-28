using ASP_Core_EF.Models;
using ASP_Core_EF.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Core_EF.Reposotory
{
    public class EnrollmentRepository : IEnrollment
    {
        private DB_Context db;
        public EnrollmentRepository(DB_Context _db)
        {
            db = _db;
        }
        //Getting all the courses info from the Database in following line
        // Included Students and Courses to get their information
        public IEnumerable<Enrollment> GetEnrollments => db.Enrollments.Include(s =>s.Students).Include(c =>c.Courses);

        public void Add(Enrollment _Enrollment)
        {
            db.Enrollments.Add(_Enrollment);
            db.SaveChanges();
        }

        public Enrollment GetEnrollment(int? Id)
        {
            //  Only one info
              Enrollment dbEntity = db.Enrollments.Find(Id);
                   return dbEntity;
        }

        public void Remove(int? Id)
        {
            Enrollment dbEntity = db.Enrollments.Find(Id);
            db.Enrollments.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
