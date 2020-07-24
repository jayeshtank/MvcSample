using System;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;

namespace StudentTest.FilterClasses
{
    public class MyTestAuthorizeAttribute : AuthorizeAttribute
    {
      public void OnAuthentication(AuthenticationContext filterContext)
        {
            if (filterContext.HttpContext.Session["UserId"] == null)
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }
    }
}