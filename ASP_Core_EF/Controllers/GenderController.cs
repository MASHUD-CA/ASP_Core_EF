﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Core_EF.Models;
using ASP_Core_EF.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Core_EF.Controllers
{
    public class GenderController : Controller
    {
        private readonly IGender _Gender;
        public GenderController(IGender _IGender)
        {
            _Gender = _IGender;
        }

        public IActionResult Index()
        {
            return View(_Gender.GetGenders);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Gender model = new Gender();
            model.GenderId = 0;
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(Gender model)
        {
            if (ModelState.IsValid)
            {
                _Gender.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? Id)
        {
            if(Id == null)
            {
                return NotFound();
            }
            else
            {
                Gender model = _Gender.GetGender(Id);
                return View(model);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _Gender.Remove(Id);
            return RedirectToAction("Index");
        }
        
        //To Get details of Gender
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            return View(_Gender.GetGender(Id));
        }

        //For Editing
        public IActionResult Edit(int? Id)
        {
            var model = _Gender.GetGender(Id);
            return View("Create", model);
        }
    }
}