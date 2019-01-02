using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vis_web.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Menu/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}