using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace Infrastructure.Shared
{
    public class EntityTypeConfiguration<TEntity, TKey> : IEntityTypeConfiguration<TEntity> where TKey: IEquatable<TKey> where TEntity : class
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey("Id");
        }

        public class CurrentDateTimeValueGenerator : ValueGenerator
        {
            public override bool GeneratesTemporaryValues => false;

            protected override object NextValue(EntityEntry entry) => DateTime.UtcNow;
        }
    }
}