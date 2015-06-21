using System.Data.Entity;
using DomainClasses;
using System.Collections.Generic;

namespace Pluralsight.DataLayer
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
        }

        DbSet<Blog> Blogs { get; set; }
        DbSet<Post> Posts { get; set; }
    }


}
