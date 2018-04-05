namespace DevExpTempTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeJournauxAssocie")]
    public partial class TypeJournauxAssocie
    {
        [Key]
        [StringLength(100)]
        public string Label { get; set; }

        [StringLength(100)]
        public string LabelCategorieRegleComptable { get; set; }

        [StringLength(100)]
        public string JournalParent { get; set; }

        [StringLength(50)]
        public string CodeCompteFlux { get; set; }

        public bool? IsTerminal { get; set; }

        public bool? ShowDescriptive { get; set; }

        [StringLength(50)]
        public string FournisseurNotation { get; set; }

        [StringLength(50)]
        public string GoodNotation { get; set; }

        [StringLength(50)]
        public string PartenaireNotation { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool? IsIncremental { get; set; }

        public bool? UniqueSupplier { get; set; }
    }
}
