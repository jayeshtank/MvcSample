using StudentApp.Model;
using StudentTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace StudentTest.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserLogin login)
        {

            if (ModelState.IsValid)
            {
//                return Redirect("Index","Ho");
            }
            return View();
        }
        // GET: Login
        public ActionResult Registratoin()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

      
    }
}