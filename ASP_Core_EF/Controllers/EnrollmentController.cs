using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Core_EF.Models;
using ASP_Core_EF.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Core_EF.Controllers
{
    public class EnrollmentController : Controller
    {
        //field
        private readonly IEnrollment _Enrollment;
        private readonly ICourse _Course;  //Added field to get info from CourseController
        private readonly IStudent _Student; //Added field to get info from StudentController
        //Constructor
        public EnrollmentController(IEnrollment _IEnrollment, ICourse _ICourse, IStudent _IStudent )
        {
            _Enrollment = _IEnrollment;
            _Course = _ICourse; // Added to get info from CourseController
            _Student = _IStudent; // Added to get info from StudentController
        }

        public IActionResult Index()
        {
            return View(_Enrollment.GetEnrollments);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Courses = _Course.GetCourses; // Added to get info from CourseController
            ViewBag.Students = _Student.GetStudents; // Added to get info from StudentController
            return View();
        }
        [HttpPost]
        public IActionResult Create(Enrollment model)
        {
            if (ModelState.IsValid)
            {
                _Enrollment.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}