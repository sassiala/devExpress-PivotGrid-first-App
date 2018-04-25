using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpTempTest.Models
{
    public class JoinArboCR_CompteFeuille
    {

        //ArboCR

        public int id { get; set; }
        
        public string Niv1 { get; set; }
        
        public string Niv2 { get; set; }
        
        public string Niv3 { get; set; }
        
        public string Niv4 { get; set; }
        
        public string Niv5 { get; set; }
        
        public string Niv6 { get; set; }
        
        public string Niv7 { get; set; }
        
        public string Niv8 { get; set; }
        
        public string Niv9 { get; set; }
        
        public string Niv10 { get; set; }
        
        public string Code_CF { get; set; }

        //Compte Feuille
        
        public string Code { get; set; }

        public string Libelle { get; set; }

        public string CodeCompteRacineParent { get; set; }

        public string TypeTiers { get; set; }

        public string CodeTiers { get; set; }

        public string AdresseLogique { get; set; }

        public string AdressePhysique { get; set; }

        public string Journal { get; set; }

        public string CategorieTiers { get; set; }

        public string CompteComptable { get; set; }


        //ArboJournal RTable

        public int AJ_id { get; set; }

        public string AJ_Label { get; set; }

        public string AJ_LabelCategorieRegleComptable { get; set; }

        public string AJ_Niv1 { get; set; }

        public string AJ_Niv2 { get; set; }

        public string AJ_Niv3 { get; set; }

        public string AJ_Niv4 { get; set; }

        public string AJ_Niv5 { get; set; }

        public string AJ_Niv6 { get; set; }

    }
}