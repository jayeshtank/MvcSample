using StudentTest.Models;
using StudentTest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentTest.Controllers
{
    public class StudentController : BaseController
    {

        [HttpGet]
        public ActionResult Index()
        {
            var lst = StudentRepository.GetAll();

            var departmentList = new List<Department>();
            departmentList.Add(new Department
            {
                DepartmentId = 1,
                ShortName = "CE",
                Name = "Computer Engineering"
            });
            departmentList.Add(new Department
            {
                DepartmentId = 2,
                ShortName = "EE",
                Name = "Electrical Engineering"
            });

           
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
            if (ModelState.IsValid)
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