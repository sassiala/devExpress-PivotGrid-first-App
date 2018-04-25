namespace DevExpTempTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ArboJournalX : DbContext
    {
        public ArboJournalX()
            : base("name=ArboJournalX")
        {
        }

        public virtual DbSet<ArboJournal> ArboJournals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArboJournal>()
                .Property(e => e.Label)
                .IsUnicode(false);

            modelBuilder.Entity<ArboJournal>()
                .Property(e => e.LabelCategorieRegleComptable)
                .IsUnicode(false);

            modelBuilder.Entity<ArboJournal>()
                .Property(e => e.Niv1)
                .IsUnicode(false);

            modelBuilder.Entity<ArboJournal>()
                .Property(e => e.Niv2)
                .IsUnicode(false);

            modelBuilder.Entity<ArboJournal>()
                .Property(e => e.Niv3)
                .IsUnicode(false);

            modelBuilder.Entity<ArboJournal>()
                .Property(e => e.Niv4)
                .IsUnicode(false);

            modelBuilder.Entity<ArboJournal>()
                .Property(e => e.Niv5)
                .IsUnicode(false);
        }
    }
}
