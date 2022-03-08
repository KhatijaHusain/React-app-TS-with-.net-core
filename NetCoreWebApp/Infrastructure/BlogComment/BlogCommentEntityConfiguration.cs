using Domain.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.BlogComment
{
    public class BlogCommentEntityConfiguration<TEntity, TKey>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.BlogComment> builder)
        {
            builder.ToTable("blogcomment");
            builder.HasKey("commentid");
            builder.Property(e => e.Comment).HasColumnName("comment");
            builder.Property(e => e.CommentedOn).HasColumnName("commentedon");
        }
    }
}
