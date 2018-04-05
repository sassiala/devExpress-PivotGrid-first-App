using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpTempTest.Controllers
{
    public class TypeJournauxAssocieController : Controller
    {
        // GET: TypeJournauxAssocie
        public ActionResult Index()
        {
            return View();
        }

        DevExpTempTest.Models.TJAContaxt db = new DevExpTempTest.Models.TJAContaxt();

        [ValidateInput(false)]
        public ActionResult TypeJournauxAssociePivotGridPartial()
        {
            var model = db.TJA;
            return PartialView("_TypeJournauxAssociePivotGridPartial", model.ToList());
        }
    }
}