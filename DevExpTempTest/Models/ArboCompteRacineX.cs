namespace DevExpTempTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ArboCompteRacineX : DbContext
    {
        public ArboCompteRacineX()
            : base("name=ArboCompteRacineX")
        {
        }

        public virtual DbSet<ArboCompteRacine> ArboCompteRacines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<ArboCompteRacine>()
                .Property(e => e.Niv1)
                .IsUnicode(false);

            modelBuilder.Entity<ArboCompteRacine>()
                .Property(e => e.Niv2)
                .IsUnicode(false);

            modelBuilder.Entity<ArboCompteRacine>()
                .Property(e => e.Niv3)
                .IsUnicode(false);

            modelBuilder.Entity<ArboCompteRacine>()
                .Property(e => e.Niv4)
                .IsUnicode(false);

            modelBuilder.Entity<ArboCompteRacine>()
                .Property(e => e.Niv5)
                .IsUnicode(false);

            modelBuilder.Entity<ArboCompteRacine>()
                .Property(e => e.Niv6)
                .IsUnicode(false);

            modelBuilder.Entity<ArboCompteRacine>()
                .Property(e => e.Niv7)
                .IsUnicode(false);

            modelBuilder.Entity<ArboCompteRacine>()
                .Property(e => e.Niv8)
                .IsUnicode(false);

            modelBuilder.Entity<ArboCompteRacine>()
                .Property(e => e.Niv9)
                .IsUnicode(false);

            modelBuilder.Entity<ArboCompteRacine>()
                .Property(e => e.Niv10)
                .IsUnicode(false);

            modelBuilder.Entity<ArboCompteRacine>()
                .Property(e => e.Code)
                .IsUnicode(false);

        }
    }
}
