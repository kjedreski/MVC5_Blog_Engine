using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hearthstone_blog.Models
{
    public class BlogDbContext : DbContext
    {

        public BlogDbContext() : base("BlogConnection")
        {
        }

        public static BlogDbContext Create()
        {
            return new BlogDbContext();
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTagMap> PostTagMap { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Category> Category { get; set; }





    }
}