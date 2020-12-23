using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ST.Controllers
{
    public class SplashController : Controller
    {
        //
        // GET: /Splash/

        public ActionResult STSplash()
        {
            return View("STSplash", "_Splash");
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
