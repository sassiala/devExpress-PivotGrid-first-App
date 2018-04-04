using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpTempTest.Controllers
{
    public class RDCController : Controller
    {
        // GET: RDC
        public ActionResult Index()
        {
            /*
            RDCHostedWebService.WebService1SoapClient _client = new RDCHostedWebService.WebService1SoapClient();
            

            int _count = _client.Count();
            int _n = (_count % 1000 == 0) ? _count / 1000 : _count / 1000 + 1;
            /*
            int _latestId = 0;
            int _i = 0;
            string _jsonData = "";
            while( _i <= 3)
            {
                //select 1000 row from db
                string[] _tab = _client.Select_N_RubriqueDocumentComptableFormaJSON(1000, _latestId);

                _latestId = Int32.Parse(_tab[1]);
                if(_tab[0] == "init")
                {
                    //result of select is empty 

                }
                else
                {
                    //result contient form json [{...},{..}]
                    if(_jsonData != "")
                    {
                        //_jsonData= [{...},{..}]
                        //Remove "]" from _jsonData
                        _jsonData = _jsonData.Remove(_jsonData.Length - 1, 1) + ",";

                        //Remove "[" from tab[0] 
                        _tab[0] = _tab[0].Remove(_tab[0][0], 1);

                    }

                    //Concat _jsonData and  _tab[0]
                    _jsonData += _tab[0];
                }
                _i++;
            }
            
            /*

            string[] _s = _client.Select_N_RubriqueDocumentComptableFormaJSON(10, 0);
            string _data = _s[0];
            
            _data = _data.Remove(_data.Length - 1, 1)+",";

            string[] _s1 = _client.Select_N_RubriqueDocumentComptableFormaJSON(10, Int32.Parse(_s[1]));

    */
            return View();
        }

        DevExpTempTest.Models.RDC db = new DevExpTempTest.Models.RDC();

        [ValidateInput(false)]
        public ActionResult PivotGridPartial()
        {
            var model = db.RubriqueDocumentComptables;
            return PartialView("_PivotGridPartial", model.ToList());
        }
    }
}