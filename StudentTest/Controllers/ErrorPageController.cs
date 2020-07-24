using System.Web.Mvc;

namespace MMDX.Web.Controllers
{
    public class ErrorPageController : Controller
    {
        // GET: ErrorPage
        [ValidateInput(false)]
        public ActionResult Error(int? code, string ErrMessage)
        {
            ViewBag.ErrorMessage = ErrMessage;
            ViewBag.ErrorCode = code;
            return View();
        }

        public ActionResult UnAuthorized(int? code, string ErrMessage)
        {
            ViewBag.ErrorMessage = "UnAuthorized Page";
            ViewBag.ErrorCode = code;
            return View("Error");
        }
    }
}