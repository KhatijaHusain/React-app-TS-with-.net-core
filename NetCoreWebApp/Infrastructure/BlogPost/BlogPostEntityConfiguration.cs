using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.BlogPost
{
    public class BlogPostEntityConfiguration //: EntityTypeConfiguration<Domain.Entities.BlogPost, long>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.BlogPost> builder)
        {
            builder.ToTable("blogposts");
            builder.Property(e=>e.blogpostid).HasColumnName("blogpostid");
            builder.Property<DateTime>(e=> e.PublishedOn).HasColumnName("publishedon");          
            builder.Property<string>(b => b.Title).HasColumnName("title").HasColumnType("string");
            builder.Property(e => e.Body).HasColumnName("body").HasColumnType("string");
            builder.OwnsMany(x => x.blogcomment);
        }
    }
}