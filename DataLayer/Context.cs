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

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Blog>().HasKey(x => x.Id).Property(x => x.Title).HasMaxLength(20);
            //modelBuilder.Entity<Blog>().Property(x => x.BloggerName).IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }


}
