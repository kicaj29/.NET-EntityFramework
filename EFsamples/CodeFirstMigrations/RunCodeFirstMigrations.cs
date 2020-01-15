using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstMigrations.Migrations;

namespace CodeFirstMigrations
{
    public class RunCodeFirstMigrations
    {
        public void Run()
        {
            // By default it connects to (LocalDb)\MSSQLLocalDB
            using (var db = new BlogContext())
            {
                db.Blogs.Add(new Blog { Name = "Another Blog " });
                db.SaveChanges();

                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(blog.Name);
                }
            }

        }

        public void RunMigrations()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogContext, Configuration>());
        }
    }
}
