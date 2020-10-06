using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.Core.Entities.Configuration
{
    internal class EntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class, IEntity
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id).HasName("Id");
            builder.Property(x => x.CreatedDate).HasColumnName("CreatedDate").HasColumnType("DateTime").HasDefaultValueSql("GETDATE()").IsRequired();
            builder.Property(x => x.ModifiedDate).HasColumnName("ModifiedDate");
            builder.Property(x => x.isActive).HasColumnName("isActive").IsRequired();

        }
    }
}
