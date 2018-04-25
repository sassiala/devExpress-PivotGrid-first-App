namespace DevExpTempTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RubriqueDocumentComptable")]
    public partial class RubriqueDocumentComptable
    {
        public int Id { get; set; }

        public int? IdDocumentComptable { get; set; }

        [StringLength(100)]
        public string TypeRubrique { get; set; }

        [StringLength(255)]
        public string CodeClasseComptable { get; set; }

        [StringLength(255)]
        public string Reference { get; set; }

        [StringLength(255)]
        public string Designation { get; set; }

        public double? Quantite { get; set; }

        public double? PrixUnitaire { get; set; }

        public double? Remise { get; set; }

        public double? Taxe { get; set; }

        public double? MontantRemise { get; set; }

        public double? MontantTaxe { get; set; }

        [StringLength(255)]
        public string NomTaxe { get; set; }

        [StringLength(255)]
        public string CodeJournal { get; set; }

        [StringLength(255)]
        public string Good { get; set; }

        [StringLength(255)]
        public string LabelJournal { get; set; }

        [StringLength(255)]
        public string JournalVariationStock { get; set; }

        [StringLength(50)]
        public string Nature { get; set; }

        [StringLength(100)]
        public string Montant { get; set; }

        public int? OrderClass { get; set; }

        public int? Signe { get; set; }

        public bool? HelperEstDeductible { get; set; }

        [StringLength(100)]
        public string HelperCompteVentillation { get; set; }

        public double? HelperPourcentageVentillation { get; set; }

        public bool? HelperEstExo { get; set; }

        public double? HelperMontantTaxeAvantExo { get; set; }

        public double? HelperMontantExo { get; set; }

        [StringLength(50)]
        public string Unite { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [Column(TypeName = "text")]
        public string Titre { get; set; }

        [Column(TypeName = "text")]
        public string TitreNomCompte { get; set; }

        public int? CodeTier { get; set; }

        public double? HTAndNet { get; set; }

        [StringLength(50)]
        public string DateCreation { get; set; }

        public string Commentaire { get; set; }

        public string RefGood { get; set; }

        public string FactureAss { get; set; }

        public string JournalAss { get; set; }

        public string SupplierAss { get; set; }

        public string CompteComptable { get; set; }
    }
}
