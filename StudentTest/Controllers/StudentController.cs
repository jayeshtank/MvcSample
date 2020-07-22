using StudentTest.Models;
using StudentTest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentTest.Controllers
{
    public class StudentController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            var lst = StudentRepository.GetAll();
            return View(lst);
        }

        // GET: Student
        [HttpGet]
        public ActionResult Create()
        {
            var student = new Student();
            student.DepartmentId = 1;
            student.Age = 18;
            student.IsActive = true;

            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            if(ModelState.IsValid)
            {
                var isInsert = StudentRepository.Insert(student);
                if (isInsert)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(student);
        }
    }
}