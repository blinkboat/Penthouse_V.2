using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Penthouse.Controllers
{
    public class LawController : Controller
    {
        // GET: Law
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult _THAI_REAL_ESTATE_LAWS()
        {

            return View();
        }
        public ActionResult _THAI_TAX_LAWS()
        {

            return View();
        }
    }
}