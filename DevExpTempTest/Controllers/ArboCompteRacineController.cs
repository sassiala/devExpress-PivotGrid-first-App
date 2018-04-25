using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpTempTest.Models;

namespace DevExpTempTest.Controllers
{
    public class ArboCompteRacineController : Controller
    {
        // GET: ArboCompteRacine
        public ActionResult Index()
        {
            return View();
        }

         

        [ValidateInput(false)]
        public ActionResult PivotGrid1Partial()
        {
            //SqlConnection _cnn = new SqlConnection(@"data source=ala-pc\sqlexpress;initial catalog=erp;integrated security=True;");
            
            SqlConnection _cnn = new SqlConnection(@"Server=SRV2;Database=erp;User Id=Administrator;Password=@dm!NS&n5890TN;");
            _cnn.Open();
            /*
            string _queryString = "" +
                "SELECT C.[Code] Code_CF" +
                 " ,C.[Libelle]" +
                 " ,C.[CodeCompteRacineParent]" +
                 " ,C.[TypeTiers]" +
                 " ,C.[CodeTiers]" +
                 " ,C.[AdresseLogique]" +
                 " ,C.[AdressePhysique]" +
                 " ,C.[Journal]" +
                 " ,C.[CategorieTiers]" +
                 " ,C.[CompteComptable]" +
                 " ,A.[id]" +
                 " ,A.[Niv1]" +
                 " ,A.[Niv2]" +
                 " ,A.[Niv3]" +
                 " ,A.[Niv4]" +
                 " ,A.[Niv5]" +
                 " ,A.[Niv6]" +
                 " ,A.[Niv7]" +
                 " ,A.[Niv8]" +
                 " ,A.[Niv9]" +
                 " ,A.[Niv10]" +
                 " ,A.[Code]" +
                 " FROM[dbo].[CompteFeuille] C, [dbo].[ArboCompteRacine]" +
                 "  A " +
                 " where C.CodeCompteRacineParent = A.Code";
                 */

            string _queryString = "" +
                "SELECT CF.[Code] Code_CF" +
                  " ,CF.[Libelle]" +
                  " ,CF.[CodeCompteRacineParent]" +
                  " ,CF.[TypeTiers]" +
                  " ,CF.[CodeTiers]" +
                  " ,CF.[AdresseLogique]" +
                  " ,CF.[AdressePhysique]" +
                  " ,CF.[CompteComptable]" +
                  " ,CF.[Journal]" +
                  " ,CF.[CategorieTiers]" +

                  " ,ACR.[id] ACR_id" +
                  " , ACR.[Niv1] ACR_Niv1" +
                  " ,ACR.[Niv2] ACR_Niv2" +
                  " , ACR.[Niv3] ACR_Niv3" +
                  " ,ACR.[Niv4] ACR_Niv4" +
                  " , ACR.[Niv5] ACR_Niv5" +
                  " ,ACR.[Niv6] ACR_Niv6" +
                  " , ACR.[Niv7] ACR_Niv7" +
                  " ,ACR.[Niv8] ACR_Niv8" +
                  " , ACR.[Niv9] ACR_Niv9" +
                  " ,ACR.[Niv10] ACR_Niv10" +
                  " , ACR.[Code] ACR_Code" +

                  " ,AJ.[id] AJ_id" +
                  " , AJ.[Label] AJ_Label" +
                  " ,AJ.[LabelCategorieRegleComptable] AJ_LabelCategorieRegleComptable" +
                  " , AJ.[Niv1] AJ_Niv1" +
                  " ,AJ.[Niv2] AJ_Niv2" +
                  " , AJ.[Niv3] AJ_Niv3" +
                  " ,AJ.[Niv4] AJ_Niv4" +
                  " , AJ.[Niv5] AJ_Niv5" +
                  " ,AJ.[Niv6] AJ_Niv6" +

                  " FROM[CompteFeuille] CF" +
                  " Full JOIN[ArboCompteRacine] ACR" +
                  " ON CF.CodeCompteRacineParent = ACR.Code" +
                  " Full JOIN[ArboJournal] AJ" +
                  " ON CF.Journal = AJ.id";

SqlCommand _cmd = new SqlCommand(_queryString, _cnn);
            SqlDataReader _reader = _cmd.ExecuteReader();

            List<JoinArboCR_CompteFeuille> _listDataReader = new List<JoinArboCR_CompteFeuille>();

            if (_reader != null)
            {
                while (_reader.Read())
                {
                    JoinArboCR_CompteFeuille _object = new JoinArboCR_CompteFeuille();
                    _object.Code_CF = (_reader["Code_CF"] == DBNull.Value) ? "" : (string)_reader["Code_CF"];
                    _object.Libelle = (_reader["Libelle"] == DBNull.Value) ? "" : (string)_reader["Libelle"];
                    _object.CodeCompteRacineParent = (_reader["CodeCompteRacineParent"] == DBNull.Value) ? "" : (string)_reader["CodeCompteRacineParent"];
                    _object.TypeTiers = (_reader["TypeTiers"] == DBNull.Value) ? "" : (string)_reader["TypeTiers"];
                    _object.CodeTiers = (_reader["CodeTiers"] == DBNull.Value) ? "" : (string)_reader["CodeTiers"];
                    _object.AdresseLogique = (_reader["AdresseLogique"] == DBNull.Value) ? "" : (string)_reader["AdresseLogique"];
                    _object.AdressePhysique = (_reader["AdressePhysique"] == DBNull.Value) ? "" : (string)_reader["AdressePhysique"];
                    _object.CompteComptable = (_reader["CompteComptable"] == DBNull.Value) ? "" : (string)_reader["CompteComptable"];
                    _object.Journal = (_reader["Journal"] == DBNull.Value) ? "" : (string)_reader["Journal"];
                    _object.CategorieTiers = (_reader["CategorieTiers"] == DBNull.Value) ? "" : (string)_reader["CategorieTiers"];

                    _object.id = (_reader["ACR_id"] == DBNull.Value) ? (new Int32()) : (int)_reader["ACR_id"];
                    _object.Niv1 = (_reader["ACR_Niv1"] == DBNull.Value) ? "" : (string)_reader["ACR_Niv1"];
                    _object.Niv2 = (_reader["ACR_Niv2"] == DBNull.Value) ? "" : (string)_reader["ACR_Niv2"];
                    _object.Niv3 = (_reader["ACR_Niv3"] == DBNull.Value) ? "" : (string)_reader["ACR_Niv3"];
                    _object.Niv4 = (_reader["ACR_Niv4"] == DBNull.Value) ? "" : (string)_reader["ACR_Niv4"];
                    _object.Niv5 = (_reader["ACR_Niv5"] == DBNull.Value) ? "" : (string)_reader["ACR_Niv5"];
                    _object.Niv6 = (_reader["ACR_Niv6"] == DBNull.Value) ? "" : (string)_reader["ACR_Niv6"];
                    _object.Niv7 = (_reader["ACR_Niv7"] == DBNull.Value) ? "" : (string)_reader["ACR_Niv7"];
                    _object.Niv8 = (_reader["ACR_Niv8"] == DBNull.Value) ? "" : (string)_reader["ACR_Niv8"];
                    _object.Niv9 = (_reader["ACR_Niv9"] == DBNull.Value) ? "" : (string)_reader["ACR_Niv9"];
                    _object.Niv10 = (_reader["ACR_Niv10"] == DBNull.Value) ? "" : (string)_reader["ACR_Niv10"];
                    _object.Code = (_reader["ACR_Code"] == DBNull.Value) ? "" : (string)_reader["ACR_Code"];

                    //ArboJournal

                    _object.AJ_id = (_reader["AJ_id"] == DBNull.Value) ? (new Int32()) : (int)_reader["AJ_id"];
                    _object.AJ_Label = (_reader["AJ_Label"] == DBNull.Value) ? "" : (string)_reader["AJ_Label"];
                    _object.AJ_LabelCategorieRegleComptable = (_reader["AJ_LabelCategorieRegleComptable"] == DBNull.Value) ? "" : (string)_reader["AJ_LabelCategorieRegleComptable"];

                    _object.AJ_Niv1 = (_reader["AJ_Niv1"] == DBNull.Value) ? "" : (string)_reader["AJ_Niv1"];
                    _object.AJ_Niv2 = (_reader["AJ_Niv2"] == DBNull.Value) ? "" : (string)_reader["AJ_Niv2"];
                    _object.AJ_Niv3 = (_reader["AJ_Niv3"] == DBNull.Value) ? "" : (string)_reader["AJ_Niv3"];
                    _object.AJ_Niv4 = (_reader["AJ_Niv4"] == DBNull.Value) ? "" : (string)_reader["AJ_Niv4"];
                    _object.AJ_Niv5 = (_reader["AJ_Niv5"] == DBNull.Value) ? "" : (string)_reader["AJ_Niv5"];
                    _object.AJ_Niv6 = (_reader["AJ_Niv6"] == DBNull.Value) ? "" : (string)_reader["AJ_Niv6"];

                    _listDataReader.Add(_object);
                }
            }
            
            return PartialView("_PivotGrid1Partial", _listDataReader);
        }
    }
}