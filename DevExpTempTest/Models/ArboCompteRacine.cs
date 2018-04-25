namespace DevExpTempTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArboCompteRacine")]
    public partial class ArboCompteRacine
    {
        public int id { get; set; }

        [Column(TypeName = "text")]
        public string Niv1 { get; set; }

        [Column(TypeName = "text")]
        public string Niv2 { get; set; }

        [Column(TypeName = "text")]
        public string Niv3 { get; set; }

        [Column(TypeName = "text")]
        public string Niv4 { get; set; }

        [Column(TypeName = "text")]
        public string Niv5 { get; set; }

        [Column(TypeName = "text")]
        public string Niv6 { get; set; }

        [Column(TypeName = "text")]
        public string Niv7 { get; set; }

        [Column(TypeName = "text")]
        public string Niv8 { get; set; }

        [Column(TypeName = "text")]
        public string Niv9 { get; set; }

        [Column(TypeName = "text")]
        public string Niv10 { get; set; }

        [Column(TypeName = "text")]
        public string Code { get; set; }
    }
}
