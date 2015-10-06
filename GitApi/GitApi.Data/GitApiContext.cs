using GitApi.Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace GitApi.Data
{
    public class GitApiContext : DbContext
    {
        public GitApiContext()
            : base("Contexto")
        {            
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Favoritos>().ToTable("Favoritos");
            base.OnModelCreating(modelBuilder);
        }        

    }
}
