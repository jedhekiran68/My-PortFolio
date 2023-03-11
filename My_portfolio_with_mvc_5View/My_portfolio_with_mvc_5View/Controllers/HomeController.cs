using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace My_portfolio_with_mvc_5View.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult home()
        {
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
        public ActionResult resume()
        {
            return View();
        }
        public ActionResult service()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
    }
}