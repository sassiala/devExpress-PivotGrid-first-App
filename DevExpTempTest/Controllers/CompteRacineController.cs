using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpTempTest.Controllers
{
    public class CompteRacineController : Controller
    {
        // GET: CompteRacine
        public ActionResult Index()
        {
            return View();
        }

        DevExpTempTest.Models.CompteRacineX db = new DevExpTempTest.Models.CompteRacineX();

        [ValidateInput(false)]
        public ActionResult CompteRacinePivotGridPartial()
        {
            var model = db.CompteRacines;
            return PartialView("_CompteRacinePivotGridPartial", model.ToList());
        }
    }
}