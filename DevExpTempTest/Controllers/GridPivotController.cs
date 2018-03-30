using DevExpress.Web.Mvc;
using DevExpTempTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace DevExpTempTest.Controllers
{
    public class GridPivotController : Controller
    {
        // GET: GridPivot
        public ActionResult Index()
        {
            return View();
        }

        //DevExpTempTest.Models.bonLivraisonERP db = new DevExpTempTest.Models.bonLivraisonERP();

        [ValidateInput(false)]
        public ActionResult PivotGrid1Partial()
        {
            //bonLivraisonWSReference.bonLivraisonWSSoapClient _client = new bonLivraisonWSReference.bonLivraisonWSSoapClient();
            
            ERPWebServices.WebService1SoapClient _client = new ERPWebServices.WebService1SoapClient();
            
            string _jsonList = _client.selectAllFromBonLivraison();


            JavaScriptSerializer _js = new JavaScriptSerializer();

            List<BonLivraison> _list = (List<BonLivraison>)_js.Deserialize(_jsonList, typeof(List<BonLivraison>));

            //var model = db.BonLivraisons;
            return PartialView("_PivotGrid1Partial", _list);
            
        }
    }
}