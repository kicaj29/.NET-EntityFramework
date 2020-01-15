namespace CodeFirstMigrations.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstMigrations.BlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CodeFirstMigrations.BlogContext";
        }

        protected override void Seed(CodeFirstMigrations.BlogContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.



            context.Blogs.AddOrUpdate(new Blog[]
            {
                new Blog(){BlogId = 1, Name = "Another Blog", Url = null, Rating = 3},
                new Blog(){BlogId = 2, Name = "ADO.NET Blog", Url = null, Rating = 4},
            });


            context.Posts.AddOrUpdate(new Post[]
            {
                new Post(){PostId = 1, Title = "Post for ASP.NET blog", Content = "Post for ASP.NET blog", BlogId = 2, Abstract = "1"}
            });
        }
    }
}
