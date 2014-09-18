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
    }
}
