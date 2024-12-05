using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_CuoiKy.App_Start;
using Web_CuoiKy.Areas.User.Dto.Request;
using Web_CuoiKy.Models;

namespace Web_CuoiKy.Areas.User.Controllers
{
    public class HomeController : Controller
    {
        private readonly DB_TravelEntities1 _db;
        public HomeController()
        {
            _db = new DB_TravelEntities1();
        }
        // GET: User/Home
        [AdminAuthorize(role = "User")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(LoginRequest loginUser)
        {
            Web_CuoiKy.Models.User user = _db.Users.Where(x=>x.Email == loginUser.email).FirstOrDefault();
            if (user != null)
            {
                if (user.Passwords == loginUser.password)
                {
                    Session["user"] = user;
                    Session.Timeout = 30;
                    return RedirectToAction("Index");
                    //var userSession = Session["user"] as Models.User;
                    //ViewBag.ErrLogin = "Thanh Cong" + userSession.Username;
                }
                else
                {
                    ViewBag.ErrLogin = "Vui long nhap dung email va mat khau!";
                }
            }
            else
            {
                ViewBag.ErrLogin = "Vui long nhap dung email va mat khau!";
            }
            return View();
        }

        public ActionResult Favourite()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult NoRole()
        {
            return View();
        }
    }
}