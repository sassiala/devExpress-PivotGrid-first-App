namespace DevExpTempTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ColisArticlesX : DbContext
    {
        public ColisArticlesX()
            : base("name=ColisArticlesX")
        {
        }

        public virtual DbSet<ColisArticle> ColisArticles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ColisArticle>()
                .Property(e => e.Good)
                .IsUnicode(false);

            modelBuilder.Entity<ColisArticle>()
                .Property(e => e.Qty)
                .IsUnicode(false);

            modelBuilder.Entity<ColisArticle>()
                .Property(e => e.Nature)
                .IsUnicode(false);
        }
    }
}
