using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hearthstone_blog.Models
{
  
    //Each post belongs to a single Category
    // Posts can be labeled with many tags
    // Post and Category the relationship is many-to-one
    // Post and Tag the relationship is many-to-many


    public class Post
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage ="The {} must be between {2} and {1} characters long", MinimumLength =5)]
        [Display(Name ="Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name ="ShortDescription")]
        [StringLength(250,ErrorMessage ="The {0} must be between {2} and {1} characters long.", MinimumLength = 20)]
        public string ShortDescription { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage ="The {0} must be between {2} and {1} characters long.", MinimumLength = 500)]
        [Display(Name ="Description")]
        public string Description { get; set;}

        [Required]
        [StringLength(25,ErrorMessage ="The {0} must be between {2} and {1} characters long.", MinimumLength =5)]
        [Display(Name = "Meta")]
        public string Meta { get; set; }

        [Required]
        [Display(Name="UrlSlug")]
        public string UrlSlug { get; set; }
        public bool Published { get; set; }
        public DateTime PostedOn { get; set; }
        public DateTime? Modified { get; set; }

        [DefaultValue(0)]
        public int NetLikeCount { get; set; }

        public string Category { get; set; }
    }

    public class Category
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [Display(Name ="Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Urlslug")]
        public string UrlSlug { get; set; }

        public string Description { get; set; }
    }

    public class Tag
    {
        public string Id { get; set; }
        [Key]
        [Required]
        [Display(Name="Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Urlslug")]
        public string UrlSlug { get; set; }

        public string Description { get; set; }

    }

    public class PostTagMap
    {
        [Key]
        public int Post_id { get; set; }
        [Key]
        public int Tag_id {get; set;}

    }


}