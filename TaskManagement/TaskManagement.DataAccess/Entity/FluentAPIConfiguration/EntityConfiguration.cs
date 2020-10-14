using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Core.Entities;

namespace TaskManagement.DataAccess.Entity.FluentAPIConfiguration
{
    public abstract class EntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class, IEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                        .UseIdentityColumn();
            builder.Property(x => x.CreatedDate)
                        .HasColumnType("smalldatetime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.ModifiedDate)
                .HasColumnType("smalldatetime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");
        }
    }
}
