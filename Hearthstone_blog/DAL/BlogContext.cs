using Hearthstone_blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hearthstone_blog.DAL
{
    public class BlogContext: DbContext
    {
     
        // Data Access Layer
        //pass connection string
        public BlogContext()
            : base("BlogContext")
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Category { get; set; }

      

    }
}