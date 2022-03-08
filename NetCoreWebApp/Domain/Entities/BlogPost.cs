using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BlogPost
    {
        public int blogpostid { get; set; }

        [Column("body")]
        public string Body { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("publishedon")]
        public DateTime PublishedOn { get; set; }
        public List<BlogComment> blogcomment { get; set; }
    }
}
