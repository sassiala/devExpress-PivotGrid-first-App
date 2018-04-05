namespace DevExpTempTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompteFeuille")]
    public partial class CompteFeuille
    {
        [Key]
        public string Code { get; set; }

        public string Libelle { get; set; }

        public string CodeCompteRacineParent { get; set; }

        public string TypeTiers { get; set; }

        public string CodeTiers { get; set; }

        public string AdresseLogique { get; set; }

        public string AdressePhysique { get; set; }

        public string Journal { get; set; }

        public string CategorieTiers { get; set; }
    }
}
