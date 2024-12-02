using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_CuoiKy.Areas.User.Controllers
{
    public class PostController : Controller
    {
        // GET: User/Post
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PostDetails()
        {
            return View();
        }
    }
}