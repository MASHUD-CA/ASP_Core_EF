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
        //Making relation with Gender table from StudentController.cs
        private readonly IGender _Gender;

        public StudentController(IStudent _IStudent, IGender _IGender)
        {
            _Student = _IStudent;
            //Making relation with Gender table from StudentController.cs
            _Gender = _IGender;
        }
        public IActionResult Index()
        {
            return View(_Student.GetStudents);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //Making relation with Gender table from StudentController.cs
            ViewBag.Genders = _Gender.GetGenders;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student model)
        {
            return View(model);
        }
    }
}