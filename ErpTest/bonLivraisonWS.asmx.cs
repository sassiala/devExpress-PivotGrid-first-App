using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using ErpTest.Model;
namespace ErpTest
{
    /// <summary>
    /// Description résumée de bonLivraisonWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class bonLivraisonWS : System.Web.Services.WebService
    {

        [WebMethod]
        public string selectAllFromBonLivraison()
        {
            SqlConnection _cnn = new SqlConnection(@"Data Source=ala-pc\sqlexpress;Initial Catalog=erp;Integrated Security=True");
            string _jsonData = null;
            
            try
            {
                _cnn.Open();

                List<BonLivraison> _list = new List<BonLivraison>();

                string _query = "SELECT * FROM BonLivraison";
                SqlCommand _cmd = new SqlCommand(_query, _cnn);
                SqlDataReader _reader = _cmd.ExecuteReader();

                BonLivraison _bl;

                if(_reader != null)
                {
                    while(_reader.Read())
                    {
                        _bl = new BonLivraison();
                        _bl.Acheminement= (string)_reader["Acheminement"];
                        _bl.DateArrive = (DateTime?)_reader["DateArrive"];
                        _bl.DateDepart = (DateTime?)_reader["DateDepart"];
                        _bl.DateEdition = (DateTime?)_reader["DateEdition"];
                        _bl.DocId = (int?)_reader["DocId"];
                        _bl.Etat = (string)_reader["Etat"];
                        _bl.Flux = (string)_reader["Flux"];
                        _bl.Id = (int)_reader["Id"];
                        _bl.JournalId = (string)_reader["JournalId"];
                        _bl.LieuActuel = (string)_reader["LieuActuel"];
                        _bl.LieuArrive = (string)_reader["LieuArrive"];
                        _bl.LieuDepart = (string)_reader["LieuDepart"];
                        _bl.NumeroBL = (string)_reader["NumeroBL"];
                        _bl.Transporteur = (string)_reader["Transporteur"];

                        _list.Add(_bl);
                    }
                }
                else
                {
                    return "Table is empty";
                }

                JavaScriptSerializer js = new JavaScriptSerializer();
                _jsonData = js.Serialize(_list);

                _cnn.Close();
            }
            catch(Exception _ex)
            {
                return "cannot connect to ERP-Db " + _ex.Message;
            }

            return _jsonData;
        }
    }
}
