namespace ErpTest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BonLivraison")]
    public partial class BonLivraison
    {
        public int Id { get; set; }

        public int? DocId { get; set; }

        [StringLength(50)]
        public string NumeroBL { get; set; }

        public DateTime? DateEdition { get; set; }

        public DateTime? DateDepart { get; set; }

        public DateTime? DateArrive { get; set; }

        [StringLength(255)]
        public string LieuDepart { get; set; }

        [StringLength(255)]
        public string LieuArrive { get; set; }

        [StringLength(255)]
        public string LieuActuel { get; set; }

        [StringLength(255)]
        public string Transporteur { get; set; }

        [StringLength(255)]
        public string Acheminement { get; set; }

        [StringLength(255)]
        public string Etat { get; set; }

        [StringLength(50)]
        public string Flux { get; set; }

        [StringLength(255)]
        public string JournalId { get; set; }
    }
}
