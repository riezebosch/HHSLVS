using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace HHSLVS
{
    public class SchoolContext : DbContext
    {
        public DbSet<Leerling> Leerlingen { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Voorbeeldje van samengestelde sleutel
            //modelBuilder
            //    .Entity<Studie>()
            //    .HasKey(s => new { s.Id, s.Naam });

            base.OnModelCreating(modelBuilder);
        }
    }
}
