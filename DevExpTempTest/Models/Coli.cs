namespace DevExpTempTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Coli
    {
        public int Id { get; set; }

        public int? BonId { get; set; }

        [StringLength(50)]
        public string NumeroColis { get; set; }

        [StringLength(50)]
        public string Poids { get; set; }

        [StringLength(50)]
        public string Volume { get; set; }

        [StringLength(50)]
        public string TypeConditionnement { get; set; }
    }
}
