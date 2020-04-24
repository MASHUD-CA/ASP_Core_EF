using ASP_Core_EF.Models;
using ASP_Core_EF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Core_EF.Reposotory
{
    public class CourseRepository : ICourse
    {
        private DB_Context db;

        public CourseRepository(DB_Context _db)
        {
            db = _db;
        }
        //Getting all the courses info from the Database in following line
        public IEnumerable<Course> GetCourses => db.Courses;

        public void Add(Course _Course)
        {
            db.Courses.Add(_Course);
            db.SaveChanges();
        }

        public Course GetCourse(int? Id)
        {
            Course dbEntity = db.Courses.Find(Id);
            return dbEntity;
        }

        public void Remove(int? Id)
        {
            Course dbEntity = db.Courses.Find(Id);
            db.Courses.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
