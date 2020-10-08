using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.Entities.Configuration;
using TaskManagement.Entities;

namespace TaskManagement.DataAccess.Entity.Configuration
{
    public class ProjectConfiguration : EntityConfiguration<Project>
    {
        public override void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(x=>x.StartDate)
                        .HasColumnType("DateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()")
                        .IsRequired();
            builder.Property(x => x.Name).HasMaxLength(300).IsRequired();
            base.Configure(builder);
        }
    }
}
