using System;
using System.IO;
using System.Text;
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
            var sb = new StringBuilder();
            sb.Append("Message : " + ex.Message);
            sb.Append("\nStackTrace : " + ex.StackTrace);
            sb.Append("\nInnerException : " + ex.InnerException);

            //File.WriteAllText(@"C:\Logs\a.txt", sb.ToString());
            //Log Error to the file
        }
    }
}