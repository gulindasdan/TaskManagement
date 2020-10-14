using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Entities;

namespace TaskManagement.DataAccess.Entity.FluentAPIConfiguration
{
    public class TaskProcessConguration : EntityConfiguration<TaskProcess>
    {
        public override void Configure(EntityTypeBuilder<TaskProcess> builder)
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
