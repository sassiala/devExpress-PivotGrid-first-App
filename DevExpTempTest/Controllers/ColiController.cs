using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpTempTest.Controllers
{
    public class ColiController : Controller
    {
        // GET: Coli
        public ActionResult Index()
        {
            return View();
        }

        DevExpTempTest.Models.ColiX db = new DevExpTempTest.Models.ColiX();

        [ValidateInput(false)]
        public ActionResult ColiPartial()
        {
            var model = db.Colis;
            return PartialView("_ColiPartial", model.ToList());
        }
    }
}