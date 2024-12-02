using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_CuoiKy.Areas.Admin.Controllers
{
    public class PromotionController : Controller
    {
        // GET: Admin/Promotion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddPromotion()
        {
            return View();
        }
    }
}