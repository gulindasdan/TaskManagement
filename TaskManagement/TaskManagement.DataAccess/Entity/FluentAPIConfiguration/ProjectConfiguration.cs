using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Entities;

namespace TaskManagement.DataAccess.Entity.FluentAPIConfiguration
{
    public class ProjectConfiguration : EntityConfiguration<Project>
    {
        public override void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(x => x.StartDate)
                        .HasColumnType("DateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()")
                        .IsRequired();
            builder.Property(x => x.Name)
                        .HasMaxLength(300).IsRequired();
            builder.HasOne(x => x.Creater)
                        .WithMany(x => x.Projects)
                        .HasForeignKey(x => x.CreaterId);
            builder.HasOne(x => x.Closer)
                        .WithMany(x => x.Projects)
                        .HasForeignKey(x => x.CloserId);
            base.Configure(builder);
        }
    }
}
