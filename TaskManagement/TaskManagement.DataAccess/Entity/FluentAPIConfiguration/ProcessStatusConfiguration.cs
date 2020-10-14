using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Entities;

namespace TaskManagement.DataAccess.Entity.FluentAPIConfiguration
{
    public class ProcessStatusConfiguration : EntityConfiguration<ProcessStatus>
    {
        public override void Configure(EntityTypeBuilder<ProcessStatus> builder)
        {
            builder.Property(x => x.StartDate)
                    .HasColumnType("DateTime")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()")
                    .IsRequired();
            base.Configure(builder);
        }
    }
}
