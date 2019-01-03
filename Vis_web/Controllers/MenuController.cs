using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vis_web.Controllers
{
    public class MenuController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Auta()
        {
            return View();
        }

        public ActionResult Rezervace()
        {
            return View();
        }


        public ActionResult Zakaznici()
        {
            return View( );
        }

        public ActionResult Zamestnanci()
        {
            return View();
        }

    }
}