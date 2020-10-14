using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Entities;

namespace TaskManagement.DataAccess.Entity.FluentAPIConfiguration
{
    public class UserConfiguration : EntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.FirstName)
                    .HasMaxLength(150)
                    .IsRequired();
            builder.Property(x => x.LastName)
                    .HasMaxLength(150)
                    .IsRequired();
            builder.HasMany(x => x.Comments)
                    .WithOne(x => x.User)
                    .HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Histories)
                    .WithOne(x => x.User)
                    .HasForeignKey(x => x.UserId);
            base.Configure(builder);
        }
    }
}
