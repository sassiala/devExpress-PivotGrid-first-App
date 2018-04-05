namespace DevExpTempTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CompteFeuilleX : DbContext
    {
        public CompteFeuilleX()
            : base("name=CompteFeuilleX")
        {
        }

        public virtual DbSet<CompteFeuille> CompteFeuilles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
