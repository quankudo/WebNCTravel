﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_CuoiKy.App_Start;

namespace Web_CuoiKy.Areas.Admin.Controllers
{
    public class TourController : Controller
    {
        // GET: Admin/Tour
        [AdminAuthorize(role = "Admin")]
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