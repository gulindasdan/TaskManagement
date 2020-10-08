using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.Entities.Configuration;
using TaskManagement.Entities;

namespace TaskManagement.DataAccess.Entity.Configuration
{
    public class ProjectStatusConfiguration : EntityConfiguration<ProjectStatus>
    {
        public override void Configure(EntityTypeBuilder<ProjectStatus> builder)
        {
            builder.Property(x => x.StartDate)
                    .HasColumnType("DateTime")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()")
                    .IsRequired();
            //builder.HasOne(x => x.Project)
            //        .WithMany(x => x.ProjectStatuses);
            //builder.HasOne(x => x.Status)
            //        .WithMany(x => x.ProjectStatuses);
            base.Configure(builder);
        }
    }
}
