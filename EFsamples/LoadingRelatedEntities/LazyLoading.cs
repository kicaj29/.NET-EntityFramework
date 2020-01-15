using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstMigrations;

namespace LoadingRelatedEntities
{
    public class LazyLoading
    {
        public void Run()
        {
            using (var context = new BlogContext())
            {
                // if lazy loading is disabled:
                // 1. navigation property is not virtual OR
                // 2. this.Configuration.LazyLoadingEnabled = false; is set in DbContex
                // then related Posts collection is NULL!
                foreach (var blog in context.Blogs)
                {
                    Debug.WriteLine(blog.Name);
                    if (blog.Posts != null)
                    {
                        foreach (var blogPost in blog.Posts)
                        {
                            Debug.WriteLine(blogPost.Title);
                        }
                    }
                }
            }
        }
    }
}
