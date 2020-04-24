using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Core_EF.Models;
using ASP_Core_EF.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Core_EF.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent _Student;

        public StudentController(IStudent _IStudent)
        {
            _Student = _IStudent;
        }
        public IActionResult Index()
        {
            return View(_Student.GetStudents);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student model)
        {
            return View(model);
        }
    }
}