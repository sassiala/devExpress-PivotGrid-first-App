using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DevExpTempTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class joinTJA_CompteRacineX : DbContext
    {
        public joinTJA_CompteRacineX()
            : base("name=joinTJA_CompteRacineX")
        {
        }

        public virtual DbSet<joinTJA_CompteRacineX> joinTJA_CompteRacine { get; set; }
    }
}