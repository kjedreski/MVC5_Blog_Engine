using Hearthstone_blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hearthstone_blog.DAL
{
    // provides seed data if db is generated
    /*
    public class BlogInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            var category = new List<Category>
            {
            new Category{Name="Hearthstone Talk",UrlSlug="HSTalk", Description="Talking about some hearthstone"}
            };

            category.ForEach(s => context.Category.Add(s));
            context.SaveChanges();
            var posts = new List<Post>
            {
            new Post{Title="Warlocks..",ShortDescription="How to get good with locks, follow these strats",Description="Warlocks are very powerful, when you do them right, Just concentrate on field control"
                 , Meta = "Warlocks strategy", UrlSlug ="Warlock Strat", Published=true,
                 PostedOn = DateTime.Parse("2015-01-01")
                }
            };
            posts.ForEach(s => context.Posts.Add(s));
            context.SaveChanges();
            var tags = new List<Tag>
            {
            new Tag{Name="Strategy",}
            };
            tags.ForEach(s => context.Tags.Add(s));
            context.SaveChanges();
        }
    } 

    */
}