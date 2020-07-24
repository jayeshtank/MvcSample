using StudentTest.FilterClasses;
using StudentTest.Repository;
using System;
using System.Web.Mvc;

namespace StudentTest.Controllers
{
    //[HandleError]
    //[MyTestErrorHandler]
    //[MyLogger]
    //[MyTestAuthorize]

    //[MyLogger]
    //[MyTestAuthorize]
    public class HomeController : BaseController
    {
        //[AllowAnonymous]
        public ActionResult Index()
        {
            var a = 0;
            //var b = 0;
            //var a = 10 / b;

            return View();
        }

       
        public ActionResult About()
        {
            var tmpTempData = string.Empty;
            var tmpViewData = string.Empty;

            if (TempData["TempTestVar"] != null)
            {
                tmpTempData = (string)TempData["TempTestVar"];
            }

            //TempData.Keep("TempTestVar");

            //if (ViewData["Test"] != null)
            //{
            //    tmpViewData = (string)ViewData["Test"];
            //}
            return View();
        }

        public ActionResult Contact()
        {
            var tmpTempData = string.Empty;
            if (TempData["TempTestVar"] != null)
            {
                tmpTempData = (string)TempData["TempTestVar"];
            }

            return View();
        }

        [HttpPost]
        [OutputCache(Duration = 10)]
        [AllowAnonymous]
        public ActionResult GetStudentCounts()
        {
            var totalCount = StudentRepository.GetStudentCount();
            return Json(new { TotalStudent = totalCount },JsonRequestBehavior.AllowGet);
        }

    }
}