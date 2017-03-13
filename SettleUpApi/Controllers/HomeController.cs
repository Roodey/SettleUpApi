using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SettleUpApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public JsonResult user()
        {
            JsonResult user = new JsonResult();
            user.Data = "{" +
                "name:tim" +
                "email:test@test.com"+
                "}";

            return Json(user.Data,JsonRequestBehavior.AllowGet);
        }

        public string[] Get()
        {
            return new string[]
            {
                "Hello",
                "World"
            };
        }
    }
}