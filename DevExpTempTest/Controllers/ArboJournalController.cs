using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpTempTest.Controllers
{
    public class ArboJournalController : Controller
    {
        // GET: ArboJournal
        public ActionResult Index()
        {
            return View();
        }

        DevExpTempTest.Models.ArboJournalX db = new DevExpTempTest.Models.ArboJournalX();

        [ValidateInput(false)]
        public ActionResult ArboJournalPivotGridPartial()
        {
            var model = db.ArboJournals;
            return PartialView("_ArboJournalPivotGridPartial", model.ToList());
        }
    }
}