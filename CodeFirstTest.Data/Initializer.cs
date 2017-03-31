using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CodeFirstTest.Domain;

namespace CodeFirstTest.Data
{
    public class Initializer : DropCreateDatabaseAlways<DbContext>
    {
        protected override void Seed(DbContext context)
        {
            if (!context.Set<Blog>().Any())
            {
                var customer1 = new Blog()
                {
                    BlogId = 1,
                    Name = "Valentin's blog",
                };

                context.Entry(customer1).State = EntityState.Added;

                var customer2 = new Blog()
                {
                    BlogId = 2,
                    Name = "CAA's blog",
                };

                context.Entry(customer2).State = EntityState.Added;

                context.SaveChanges();

            }
        }
    }
}
