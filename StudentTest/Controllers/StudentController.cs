using StudentApp.Business;
using StudentApp.Model;
using System.Collections.Generic;
using System.Web.Mvc;

namespace StudentTest.Controllers
{
    public class StudentController : BaseController
    {
        private StudentManager _studentManager;

        public StudentController()
        {
            _studentManager = new StudentManager();
        }


        [HttpGet]
        public ActionResult Index()
        {
            var lst = _studentManager.GetAllStudent();

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
            var student = new StudentViewModel();
            student.DepartmentId = 1;
            student.Age = 18;
            student.IsActive = true;

            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentViewModel student)
        {
            if (ModelState.IsValid)
            {
                var isInsert = _studentManager.InsertStudent(student);
                if (isInsert)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(student);
        }
    }
}