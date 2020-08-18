using StudentTest.Models;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Web.Mvc;

namespace StudentTest.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult TestA()
        {
            return View();
        }

        public ActionResult TestTabs()
        {
            return View("TestTabs");
        }

        public ActionResult TestB()
        {
            var path = @"C:\Users\j.tank\Desktop\Dest\013-0015-JDF_PreOp_09_13_2019_08_34_38.pdf";
            return File(path, "application/pdf", "DownloadA.pdf");
        }

        public ActionResult TestC()
        {
            var sb = new StringBuilder();
            sb.Append("<h3>This is my content</h3>");
            sb.Append("<i>This is my content</i>");
            return Content(sb.ToString());
        }

        public ContentResult TestD()
        {
            return Content(
                    "<script> alert('I am javascript') </script>"
                        );
        }

        public EmptyResult TestE()
        {
            return new EmptyResult();
        }

        public ActionResult TestF()
        {
            return new EmptyResult();
        }

        public FileResult TestG()
        {
            var path = @"C:\Users\j.tank\Desktop\Dest\DotNetCodingStandard.pdf";
            return File(path, "application/pdf", "OutFile.pdf");
        }

        public ActionResult TestH()
        {
            //byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Files/text.txt"));  
            //return File("~/Files/text.txt", "text/plain");
            var path = @"C:\Users\j.tank\Desktop\Dest\DotNetCodingStandard.pdf";
            return File(path, "application/pdf", "OutFile.pdf");
        }

        public JsonResult TestI()
        {
            return Json("Test string", JsonRequestBehavior.AllowGet);
        }

        public ActionResult TestJ()
        {
            //var lstStudent = new List<Student>();
            //lstStudent.Add(new Student
            //{
            //    StudentId = 1,
            //    FirstName = "Jayesh",
            //    LastName = "Tank"
            //});

            //lstStudent.Add(new Student
            //{
            //    StudentId = 2,
            //    FirstName = "Rahul",
            //    LastName = "Dhokia"
            //});
            return Json(null, JsonRequestBehavior.AllowGet);
        }

        public RedirectResult TestK()
        {
            return Redirect("https://www.google.com");
        }

        public RedirectToRouteResult TestL()
        {
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }

        public HttpStatusCodeResult TestM()
        {
            return new HttpStatusCodeResult(HttpStatusCode.Unauthorized, "You are not authorized.");
            //    return new HttpUnauthorizedResult("Sorry! You don't have access.");  
        }
        public HttpNotFoundResult TestN()
        {
            return HttpNotFound("Sorry! the page you are looking for is not found.");
        }
    }
}