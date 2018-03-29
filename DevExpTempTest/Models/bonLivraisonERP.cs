namespace DevExpTempTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class bonLivraisonERP : DbContext
    {
        public bonLivraisonERP()
            : base("name=bonLivraisonERP")
        {
        }

        public virtual DbSet<BonLivraison> BonLivraisons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BonLivraison>()
                .Property(e => e.NumeroBL)
                .IsUnicode(false);

            modelBuilder.Entity<BonLivraison>()
                .Property(e => e.LieuDepart)
                .IsUnicode(false);

            modelBuilder.Entity<BonLivraison>()
                .Property(e => e.LieuArrive)
                .IsUnicode(false);

            modelBuilder.Entity<BonLivraison>()
                .Property(e => e.LieuActuel)
                .IsUnicode(false);

            modelBuilder.Entity<BonLivraison>()
                .Property(e => e.Transporteur)
                .IsUnicode(false);

            modelBuilder.Entity<BonLivraison>()
                .Property(e => e.Acheminement)
                .IsUnicode(false);

            modelBuilder.Entity<BonLivraison>()
                .Property(e => e.Etat)
                .IsUnicode(false);

            modelBuilder.Entity<BonLivraison>()
                .Property(e => e.Flux)
                .IsUnicode(false);

            modelBuilder.Entity<BonLivraison>()
                .Property(e => e.JournalId)
                .IsUnicode(false);
        }
    }
}
