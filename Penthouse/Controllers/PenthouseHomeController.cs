using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Penthouse.Models;
using Penthouse.Dbs;
namespace Penthouse.Controllers
{
    public class PenthouseHomeController : Controller
    {
        // GET: PenthouseHome
        public ActionResult Index()
        {
           HenhaodealEntities pdb = new HenhaodealEntities();
            var query = (from c in pdb.P_bannner_homepage
                         where (c.status==1)
                         orderby (c.C_index)
                         select c).ToList();

            return View(query);
        }

        public ActionResult Thankyou(string name, string email, string number, string prjname, string comments)
        {
            EmailTemplate tp = new EmailTemplate();
            tp.MessageUs(name, email, number, prjname, comments);
            return View();
        }
    }
}