using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebRedisSessionManagement.Controllers
{
    public class RedisSessionController : Controller
    {
        // GET: RedisSession
        public ActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Register(string username, string userid)
        {
            Session["usuario"] = username;
            Session["id"] = userid; 

            return RedirectToAction("Index");

        }
    }
}