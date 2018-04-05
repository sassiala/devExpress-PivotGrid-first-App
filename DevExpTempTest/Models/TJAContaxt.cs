
namespace DevExpTempTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TJAContaxt : DbContext
    {
        public TJAContaxt()
            : base("name=TJAContaxt")
        {
        }

        public virtual DbSet<TypeJournauxAssocie> TJA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeJournauxAssocie>()
                .Property(e => e.CodeCompteFlux)
                .IsUnicode(false);

            modelBuilder.Entity<TypeJournauxAssocie>()
                .Property(e => e.FournisseurNotation)
                .IsUnicode(false);

            modelBuilder.Entity<TypeJournauxAssocie>()
                .Property(e => e.GoodNotation)
                .IsUnicode(false);
            
            modelBuilder.Entity<TypeJournauxAssocie>()
                .Property(e => e.JournalParent)
                .IsUnicode(false);

            modelBuilder.Entity<TypeJournauxAssocie>()
                .Property(e => e.Label)
                .IsUnicode(false);

            modelBuilder.Entity<TypeJournauxAssocie>()
                .Property(e => e.LabelCategorieRegleComptable)
                .IsUnicode(false);

            modelBuilder.Entity<TypeJournauxAssocie>()
                .Property(e => e.PartenaireNotation)
                .IsUnicode(false);
            
            
        }
    }
}