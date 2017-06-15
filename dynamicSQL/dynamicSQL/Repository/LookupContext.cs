using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace dynamicSQL.Repository

{
    public class LookupContext : DbContext
    {
        private DbContext context;

        public LookupContext() : base("LookupContextConfig")
        {
            Database.SetInitializer(new EntityDBInitializer());
        }

        public DbSet<LookupName> Lookups { get; set; }
        public DbSet<ColumnName> cols { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
