using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilipSiteCoreTraining.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DemoComponent()
        {
            var item = Sitecore.Context.Database.GetItem("{92E860DE-3097-4835-9B18-43579B3C5F9F}");
            string str = item.Fields["Copyright"].Value;
            return View("~/Views/ControllerDemo.cshtml", item);
        }
    }
}