using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hearthstone_blog.Models
{
    public class Tag
    {
     
        public int TagId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Urlslug")]
        public string UrlSlug { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

    }
}