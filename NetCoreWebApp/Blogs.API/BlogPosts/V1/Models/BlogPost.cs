using Blogs.API.BlogComments.V1.Models;
using System;
using System.Collections.Generic;

namespace Blogs.API.BlogPosts.V1.Models
{
    public class BlogPost
    {
        public int blogpostid { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }
        public DateTime PublishedOn { get; set; }
        public List<BlogComment> BlogComment { get; set; }
    }
}
