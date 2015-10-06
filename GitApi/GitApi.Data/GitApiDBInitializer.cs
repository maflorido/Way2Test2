using System.Collections.Generic;
using System.Data.Entity;

namespace GitApi.Data
{
    internal class GitApiDBInitializer : DropCreateDatabaseAlways<GitApiContext>
    {
        protected override void Seed(GitApiContext context)
        {            
            base.Seed(context);
        }        
    }
}
