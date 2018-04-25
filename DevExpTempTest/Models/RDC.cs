namespace DevExpTempTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RDC : DbContext
    {
        public RDC()
            : base("name=RDC")
        {
        }

        public virtual DbSet<RubriqueDocumentComptable> RubriqueDocumentComptables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.TypeRubrique)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.CodeClasseComptable)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.Reference)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.Designation)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.NomTaxe)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.CodeJournal)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.Good)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.LabelJournal)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.JournalVariationStock)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.Nature)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.Montant)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.HelperCompteVentillation)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.Unite)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.Titre)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.TitreNomCompte)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.DateCreation)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.Commentaire)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.RefGood)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.FactureAss)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.JournalAss)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.SupplierAss)
                .IsUnicode(false);

            modelBuilder.Entity<RubriqueDocumentComptable>()
                .Property(e => e.CompteComptable)
                .IsUnicode(false);
        }
    }
}
