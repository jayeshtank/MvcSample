
using StudentTest.Models;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;

namespace StudentTest.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewData["Test"] = "View Data Example";
            ViewBag.Test2 = "This is view Bag Example";
            TempData["TempTestVar"] = "This is temp data";
            //TempData
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
            //    tmpViewData = (string)TempData["Test"];
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
    }
}