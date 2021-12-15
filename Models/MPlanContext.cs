using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPlan.Models
{
    public class MPlanContext:DbContext
    {
        public DbSet<Plans> DBPlan { get; set; }
        public DbSet<Items> DBItem { get; set; }
        public DbSet<Users> DBUsers { get; set; }
        public DbSet<ItemComments> DBIComments { get; set; }
        public DbSet<ItemPoints> DBIPoints { get; set; }
        public DbSet<PlanComments> DBPComments { get; set; }
        public DbSet<PlanPoints> DBPPoints { get; set; }
        public MPlanContext(DbContextOptions<MPlanContext> options):base(options) 
        { 
 
        }

    }
}
