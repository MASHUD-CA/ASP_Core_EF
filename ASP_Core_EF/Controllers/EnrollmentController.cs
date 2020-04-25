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

        //Constructor
        public EnrollmentController(IEnrollment _IEnrollment)
        {
            _Enrollment = _IEnrollment;
        }

        public IActionResult Index()
        {
            return View(_Enrollment.GetEnrollments);
        }
        [HttpGet]
        public IActionResult Create()
        {
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