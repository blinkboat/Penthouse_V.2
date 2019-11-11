using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Penthouse.Models;

namespace Penthouse.Controllers
{
    public class PenthouseHomeController : Controller
    {
        // GET: PenthouseHome
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MailAlert(string name, string email, string number, string prjname, string comments)
        {
            EmailTemplate tp = new EmailTemplate();
            tp.MessageUs(name, email, number, prjname, comments);
            return RedirectToAction("Thankyou", "Penthouse");
        }
    }
}