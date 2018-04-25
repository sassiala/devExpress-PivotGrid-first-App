using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DevExpTempTest.Controllers
{
    public class ColisArticlesController : Controller
    {
        // GET: ColisArticles
        public ActionResult Index()
        {
            return View();
        }

        DevExpTempTest.Models.ColisArticlesX db = new DevExpTempTest.Models.ColisArticlesX();

        [ValidateInput(false)]
        public ActionResult PivotGrid3Partial()
        {
            var model = db.ColisArticles;
            return PartialView("_PivotGrid3Partial", model.ToList());
        }
    }
}