using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpTempTest.Models;

namespace DevExpTempTest.Controllers
{
    public class TJAJoinCompteRacineController : Controller
    {
        // GET: TJAJoinCompteRacine
        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult JoinPivotGridPartial()
        {
            SqlConnection _cnn = new SqlConnection(@"Server=SRV2;Database=erp;User Id=Administrator;Password=@dm!NS&n5890TN;");
            _cnn.Open();

            string _queryString = ""+
            "SELECT j.[Label]"+
      ",j.[LabelCategorieRegleComptable]"+
      ",j.[JournalParent]"+
      ",j.[IsTerminal] IsTerminal_TJA " +
      ",j.[ShowDescriptive]"+
      ",j.[FournisseurNotation]"+
      ",j.[GoodNotation]"+
      ",j.[PartenaireNotation]"+
      ",j.[Id]"+
      ",j.[IsIncremental]"+
      ",j.[UniqueSupplier]"+
	  
      ",j.[CodeCompteFlux]"+
	  ",c.[Code]"+
      ",c.[Libelle]"+
      ",c.[NatureCompte]"+
      ",c.[CodeCompteParent]"+
      ",c.[TypeGestion]"+
      ",c.[CodePeride_Exercice]"+
      ",c.[CodeVentillation]"+
      ",c.[IsTerminal]"+
      ",c.[Descriptif]"+
      ",c.[ShowDescriptif]"+
 " FROM[dbo].[TypeJournauxAssocie] j, [dbo].[CompteRacine]"+
        " c"+
" where j.CodeCompteFlux = c.Code";

            
            SqlCommand _cmd = new SqlCommand(_queryString, _cnn);
            SqlDataReader _reader = _cmd.ExecuteReader();

            List<joinTJA_CompteRacine> _listDataReader = new List<joinTJA_CompteRacine>();

            if (_reader != null)
            {
                while (_reader.Read())
                {
                    joinTJA_CompteRacine _object = new joinTJA_CompteRacine();
                    _object.Label = (_reader["Label"] == DBNull.Value) ? "" : (string)_reader["Label"];
                    _object.LabelCategorieRegleComptable = (_reader["LabelCategorieRegleComptable"] == DBNull.Value) ? "" : (string)_reader["LabelCategorieRegleComptable"];
                    _object.JournalParent = (_reader["JournalParent"] == DBNull.Value) ? "" : (string)_reader["JournalParent"];
                    _object.CodeCompteFlux = (_reader["CodeCompteFlux"] == DBNull.Value) ? "" : (string)_reader["CodeCompteFlux"];
                    _object.IsTerminal_TJA = (bool)_reader["IsTerminal_TJA"];
                    _object.ShowDescriptive = (bool)_reader["ShowDescriptive"];
                    _object.FournisseurNotation = (_reader["FournisseurNotation"] == DBNull.Value) ? "" : (string)_reader["FournisseurNotation"];
                    _object.GoodNotation = (_reader["GoodNotation"] == DBNull.Value) ? "" : (string)_reader["GoodNotation"];
                    _object.PartenaireNotation = (_reader["PartenaireNotation"] == DBNull.Value) ? "" : (string)_reader["PartenaireNotation"];
                    _object.Id = (int)_reader["Id"];
                    _object.IsIncremental = (bool)_reader["IsIncremental"];
                    _object.UniqueSupplier = (bool)_reader["UniqueSupplier"];
                    // _object._pere = (string)_select["JournalParent"];
                    _object.ShowDescriptif = (bool)_reader["ShowDescriptif"];
                    _object.Descriptif = (_reader["Descriptif"] == DBNull.Value) ? "" : (string)_reader["Descriptif"];
                    _object.IsTerminal = (bool)_reader["IsTerminal"];
                    _object.CodeVentillation = (int)_reader["CodeVentillation"];
                    _object.CodePeride_Exercice = (_reader["CodePeride_Exercice"] == DBNull.Value) ? "" : (string)_reader["CodePeride_Exercice"];
                    _object.TypeGestion = (_reader["TypeGestion"] == DBNull.Value) ? "" : (string)_reader["TypeGestion"];
                    _object.CodeCompteParent = (_reader["CodeCompteParent"] == DBNull.Value) ? "" : (string)_reader["CodeCompteParent"];
                    _object.NatureCompte = (_reader["NatureCompte"] == DBNull.Value) ? "" : (string)_reader["NatureCompte"];
                    _object.Libelle = (_reader["Libelle"] == DBNull.Value) ? "" : (string)_reader["Libelle"];
                    _object.Code = (_reader["Code"] == DBNull.Value) ? "" : (string)_reader["Code"];

                    _listDataReader.Add(_object);
                }
            }
            
            return PartialView("_JoinPivotGridPartial", _listDataReader);
        }
    }
}