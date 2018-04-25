using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpTempTest.Models
{
    public class joinTJA_CompteRacine
    {
        
        public string Code { get; set; }
        
        public string Libelle { get; set; }
        
        public string NatureCompte { get; set; }
        
        public string CodeCompteParent { get; set; }
        
        public string TypeGestion { get; set; }
        
        public string CodePeride_Exercice { get; set; }

        public int? CodeVentillation { get; set; }

        public bool? IsTerminal { get; set; }
        
        public string Descriptif { get; set; }

        public bool? ShowDescriptif { get; set; }

        
        public string Label { get; set; }
        
        public string LabelCategorieRegleComptable { get; set; }
        
        public string JournalParent { get; set; }
        
        public string CodeCompteFlux { get; set; }

        public bool? IsTerminal_TJA { get; set; }

        public bool? ShowDescriptive { get; set; }
        
        public string FournisseurNotation { get; set; }
        
        public string GoodNotation { get; set; }
        
        public string PartenaireNotation { get; set; }
        
        public int Id { get; set; }

        public bool? IsIncremental { get; set; }

        public bool? UniqueSupplier { get; set; }
    }
}