using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers
{
    public class HomeController : Controller
    {
        private Idata d;
        public HomeController(Idata dd)
        {
            d = dd;
        }
        // GET: Home
        public ActionResult Index()
        {
            //ViewBag.ViewBag = "ViewBag";
            //ViewData["ViewData"] = "ViewData";
            //TempData["TempData"] = "TempData";
            return View(); ;
        }
    }
}