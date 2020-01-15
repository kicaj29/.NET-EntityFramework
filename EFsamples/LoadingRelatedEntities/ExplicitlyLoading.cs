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
    public class ExplicitlyLoading
    {
        public void Run()
        {
            using (var context = new BlogContext())
            {
                var post = context.Posts.Find(1);

                // Load the blog related to a given post
                context.Entry(post).Reference(p => p.Blog).Load();

                Debug.WriteLine(post.Blog.Name);

                // Load the blog related to a given post using a string  
                context.Entry(post).Reference("Blog").Load();

                var blog = context.Blogs.Find(2);

                // Load the posts related to a given blog
                context.Entry(blog).Collection(p => p.Posts).Load();
                foreach (var p in blog.Posts)
                {
                    Debug.Write(p.Title);
                }

                // Load the posts related to a given blog  
                // using a string to specify the relationship
                context.Entry(blog).Collection("Posts").Load();
            }

            // Applying filters when explicitly loading related entities

            using (var context = new BlogContext())
            {
                var blog = context.Blogs.Find(2);

                // assuming that lazy loading is disabled we have to explicit call Load method to load related children 

                // no posts:
                if (blog.Posts != null)
                {
                    foreach (var post in blog.Posts)
                    {
                        Debug.WriteLine(post.Title);
                    }
                }

                context.Entry(blog)
                    .Collection(b => b.Posts)
                    .Query()
                    .Where(p => p.Title == "Post for ASP.NET blog")
                    .Load();
                
                // posts are printed
                foreach (var post in blog.Posts)
                {
                    Debug.WriteLine(post.Title);
                }

                /*context.Entry(blog)
                    .Collection("Posts")
                    .Query()
                    .Where(p => ((Post)p).Title == "Post for ASP.NET blog")
                    .Load();*/
            }
        }
    }
}
