using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebElReyCan.Data;
using WebElReyCan.Models;

namespace WebElReyCan.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] // /Home/Index
        public ActionResult Index()
        {
            ViewBag.Date = DateTime.Now.ToShortDateString();
            return View();
        }
    }
}