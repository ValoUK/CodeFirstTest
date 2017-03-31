using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CodeFirstTest.Domain;

namespace CodeFirstTest.Data
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(string connectionStringName)
            : base (connectionStringName)
        {
            //Database.SetInitializer<BloggingContext>(new Initializer());
        }

        public BloggingContext()
            : base("name=DefaultConnection")
        {
            Database.SetInitializer<BloggingContext>(new Initializer());
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
