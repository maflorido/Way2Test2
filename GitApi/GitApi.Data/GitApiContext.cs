using System.Collections.Generic;
using System.Data.Entity;

namespace GitApi.Data
{
    public class GitApiContext : DbContext
    {
        public GitApiContext()
            : base("Contexto")
        {
            Database.SetInitializer<GitApiContext>(new GitApiDBInitializer());
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Produto>().ToTable("Produto");
            base.OnModelCreating(modelBuilder);
        }        

    }
}
