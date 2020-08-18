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

            TempData.Keep("TempTestVar");

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
            var totalCount = 10;//StudentRepository.GetStudentCount();
            return Json(new { TotalStudent = totalCount },JsonRequestBehavior.AllowGet);
        }

    }
}