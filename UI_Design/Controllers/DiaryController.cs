using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI_Design.Controllers
{
    public class DiaryController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Message = "Your My Cats page.";

            return View();
        }

        public ActionResult DashBoard()
        {
            ViewBag.Message = "Dash board.";

            return View();
        }

        public ActionResult RitaDiary()
        {
            ViewBag.Message = "Rita's Diary.";

            return View();
        }

        public ActionResult RitaDiarySidebar()
        {
            ViewBag.Message = "Rita's Diary.";

            return View();
        }

        public ActionResult AddCat()
        {
            ViewBag.Message = "Add new cat.";

            return View();
        }
    }
}