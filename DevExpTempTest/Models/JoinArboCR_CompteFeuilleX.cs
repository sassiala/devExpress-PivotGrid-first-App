using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DevExpTempTest.Models
{
    public class JoinArboCR_CompteFeuilleX : DbContext
    {
        public JoinArboCR_CompteFeuilleX()
            : base("name=JoinArboCR_CompteFeuille")
        {
        }

        public virtual DbSet<JoinArboCR_CompteFeuille> JoinArboCR_CompteFeuille { get; set; }
    }
}