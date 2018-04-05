namespace DevExpTempTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ColisArticle
    {
        public int Id { get; set; }

        public int? ColisId { get; set; }

        [StringLength(50)]
        public string Good { get; set; }

        [StringLength(50)]
        public string Qty { get; set; }

        public int? DocId { get; set; }

        [StringLength(50)]
        public string Nature { get; set; }
    }
}
