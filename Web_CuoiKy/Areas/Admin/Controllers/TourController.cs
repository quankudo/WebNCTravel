using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_CuoiKy.Areas.Admin.Controllers
{
    public class TourController : Controller
    {
        // GET: Admin/Tour
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddTour()
        {
            return View();
        }
    }
}