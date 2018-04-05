namespace DevExpTempTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompteRacine")]
    public partial class CompteRacine
    {
        [Key]
        [StringLength(100)]
        public string Code { get; set; }

        [StringLength(100)]
        public string Libelle { get; set; }

        [StringLength(100)]
        public string NatureCompte { get; set; }

        [StringLength(100)]
        public string CodeCompteParent { get; set; }

        [StringLength(25)]
        public string TypeGestion { get; set; }

        [StringLength(25)]
        public string CodePeride_Exercice { get; set; }

        public int? CodeVentillation { get; set; }

        public bool? IsTerminal { get; set; }

        [StringLength(200)]
        public string Descriptif { get; set; }

        public bool? ShowDescriptif { get; set; }
    }
}
