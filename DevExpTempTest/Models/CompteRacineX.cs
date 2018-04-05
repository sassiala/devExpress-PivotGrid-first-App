namespace DevExpTempTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CompteRacineX : DbContext
    {
        public CompteRacineX()
            : base("name=CompteRacineX")
        {
        }

        public virtual DbSet<CompteRacine> CompteRacines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompteRacine>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<CompteRacine>()
                .Property(e => e.Libelle)
                .IsUnicode(false);

            modelBuilder.Entity<CompteRacine>()
                .Property(e => e.NatureCompte)
                .IsUnicode(false);

            modelBuilder.Entity<CompteRacine>()
                .Property(e => e.CodeCompteParent)
                .IsUnicode(false);

            modelBuilder.Entity<CompteRacine>()
                .Property(e => e.TypeGestion)
                .IsUnicode(false);

            modelBuilder.Entity<CompteRacine>()
                .Property(e => e.CodePeride_Exercice)
                .IsUnicode(false);

            modelBuilder.Entity<CompteRacine>()
                .Property(e => e.Descriptif)
                .IsUnicode(false);
        }
    }
}
