using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ErpTest.Model;
using System.Web.Script.Serialization;
using System.ServiceModel;
using System.Net;
using System.Collections.Specialized;

namespace DevExpTempTest.Controllers
{
    public class bonLivraisonController : Controller
    {
        // GET: bonLivraison
        public ActionResult Index()
        {
            /*
            bonLivraisonWSReference.bonLivraisonWSSoapClient _client = new bonLivraisonWSReference.bonLivraisonWSSoapClient();
            string _jsonList = _client.selectAllFromBonLivraison();
            

            return View(_jsonList);
            */
            return View();
            /*
            JavaScriptSerializer _js = new JavaScriptSerializer();

            List<BonLivraison> _list = (List<BonLivraison>)_js.Deserialize(_jsonList, typeof(List<BonLivraison>));

            return View(_list);
            */
        }
    }
}