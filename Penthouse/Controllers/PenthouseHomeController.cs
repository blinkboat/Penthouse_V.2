using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Penthouse.Controllers
{
    public class PenthouseHomeController : Controller
    {
        // GET: PenthouseHome
        public ActionResult Index()
        {
            return View();
        }
    }
}