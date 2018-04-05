namespace DevExpTempTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ColiX : DbContext
    {
        public ColiX()
            : base("name=ColiX")
        {
        }

        public virtual DbSet<Coli> Colis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coli>()
                .Property(e => e.NumeroColis)
                .IsUnicode(false);

            modelBuilder.Entity<Coli>()
                .Property(e => e.Poids)
                .IsUnicode(false);

            modelBuilder.Entity<Coli>()
                .Property(e => e.Volume)
                .IsUnicode(false);

            modelBuilder.Entity<Coli>()
                .Property(e => e.TypeConditionnement)
                .IsUnicode(false);
        }
    }
}
