using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace StudentTest
{
    public class MyTestErrorHandler : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            Log(filterContext.Exception);

            base.OnException(filterContext);

            //filterContext.Result = new RedirectResult("~/ErrorPage/Error?ErrMessage=" +
            //                   HttpContext.Current.Server.UrlEncode(
            //                       HttpContext.Current.Server.HtmlEncode(filterContext.Exception.Message))); //filterContext.Exception.Message
            //filterContext.ExceptionHandled = true;

        }

        public void Log(Exception ex)
        {
            //File.WriteAllText(@"C:\Logs\a.txt", ex.Message + ex.StackTrace);
            //Log Error to the file
        }
    }
}