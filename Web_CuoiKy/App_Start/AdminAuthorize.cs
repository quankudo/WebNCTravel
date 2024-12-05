using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_CuoiKy.Models;

namespace Web_CuoiKy.App_Start
{
    public class AdminAuthorize : AuthorizeAttribute
    {
        public string role {  get; set; }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            User user = HttpContext.Current.Session["user"] as User;
            if (user != null)
            {
                DB_TravelEntities1 db = new DB_TravelEntities1();

                User roleName = db.Users.Where(x => x.UserId == user.UserId).FirstOrDefault();
                if (roleName.Roles.Equals(role) || roleName.Roles.Equals("Admin"))
                {
                    return;
                }
                else
                {
                    var returnUrl = filterContext.RequestContext.HttpContext.Request.RawUrl;
                    filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary
                    (
                        new
                        {
                            controller = "Home",
                            action = "NoRole",
                            area = "User",
                            returnUrl = returnUrl.ToString()
                        }
                    ));
                }
            }
            else
            {
                var returnUrl = filterContext.RequestContext.HttpContext.Request.RawUrl;
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary
                (
                    new
                    {
                        controller = "Home",
                        action = "LogIn",
                        area = "User",
                        returnUrl = returnUrl.ToString()
                    }
                ));
            }
        }
    }
}