using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_CuoiKy.Models;

namespace Web_CuoiKy.Areas.User.Controllers
{
    public class TourController : Controller
    {
        // GET: User/Tour
        private readonly DB_TravelEntities1 _db;
        public TourController()
        {
            _db = new DB_TravelEntities1();
        }
        public ActionResult Index()
        {
            ViewBag.ListTour = _db.Tours.ToList();
            return View();
        }

        public ActionResult TourDetails()
        {
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }
    }
}