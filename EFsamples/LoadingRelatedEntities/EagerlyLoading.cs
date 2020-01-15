using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstMigrations;

namespace LoadingRelatedEntities
{
    public class EagerlyLoading
    {
        public void Run()
        {
            using (var context = new BlogContext())
            {
                // Load all blogs and related posts
                /*var blogs1 = context.Blogs
                    .Include(b => b.Posts)
                    .ToList();*/

                // if we do not use include then during reading from Posts is executed additional query in DB
                var blogs1 = context.Blogs.ToList();

                foreach (var blog in blogs1)
                {
                    Debug.WriteLine(blog.Name);
                    foreach (var blogPost in blog.Posts)
                    {
                        Debug.WriteLine(blogPost.Title);
                    }
                }

                // Load one blogs and its related posts
                var blog1 = context.Blogs
                    .Where(b => b.Name == "ADO.NET Blog")
                    .Include(b => b.Posts)
                    .FirstOrDefault();

                // Load all blogs and related posts  
                // using a string to specify the relationship
                var blogs2 = context.Blogs
                    .Include("Posts")
                    .ToList();

                // Load one blog and its related posts  
                // using a string to specify the relationship
                var blog2 = context.Blogs
                    .Where(b => b.Name == "ADO.NET Blog")
                    .Include("Posts")
                    .FirstOrDefault();
            }
        }

        public void RunLoadingMultipleLevels()
        {
            using (var context = new BlogContext())
            {
                // Load all blogs, all related posts, and all related comments
                var blogs1 = context.Blogs
                    .Include(b => b.Posts.Select(p => p.Comments))
                    .ToList();

                // Load all blogs, all related posts, and all related comments  
                // using a string to specify the relationships
                var blogs2 = context.Blogs
                    .Include("Posts.Comments")
                    .ToList();
            }
        }
    }
}
