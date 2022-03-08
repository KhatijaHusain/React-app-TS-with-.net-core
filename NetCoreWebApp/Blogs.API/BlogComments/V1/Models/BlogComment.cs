using Blogs.API.BlogPosts.V1.Models;
using System;

namespace Blogs.API.BlogComments.V1.Models
{
    public class BlogComment
    {
        public int CommentId { get; set; }
        public string Comment { get; set; }
        public DateTime CommentedOn { get; set; }
    }
}
