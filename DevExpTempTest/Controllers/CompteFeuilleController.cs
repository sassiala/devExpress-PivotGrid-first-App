using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpTempTest.Controllers
{
    public class CompteFeuilleController : Controller
    {
        // GET: CompteFeuille
        public ActionResult Index()
        {
            return View();
        }

        DevExpTempTest.Models.CompteFeuilleX db = new DevExpTempTest.Models.CompteFeuilleX();

        [ValidateInput(false)]
        public ActionResult PivotGrid4Partial()
        {
            var model = db.CompteFeuilles;
            return PartialView("_PivotGrid4Partial", model.ToList());
        }
    }
}