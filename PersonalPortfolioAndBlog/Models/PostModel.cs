using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalPortfolioAndBlog.Models
{
    public class PostModel
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public string FeaturedImage { get; set; }
        public string Excerpt { get; set; }
        public string Content { get; set; }
    }
}
