using Domain.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BlogComment

    {
        [Key]
        [Column("commentid")]
        public int CommentId { get; set; }
        [Column("comment")]
        public string Comment { get; set; }
        [Column("commentedon")]
        public DateTime CommentedOn { get; set; }
        
    }
}
