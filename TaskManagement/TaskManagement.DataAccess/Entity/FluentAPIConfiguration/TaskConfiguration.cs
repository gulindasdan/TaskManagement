﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TaskManagement.Entities;

namespace TaskManagement.DataAccess.Entity.FluentAPIConfiguration
{
    public class TaskConfiguration : EntityConfiguration<Task>
    {
        public override void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.Property(x => x.Title)
                        .IsRequired();
            builder.HasOne(x => x.Project)
                        .WithMany(x => x.Tasks);
            builder.HasMany(x => x.Attachments)
                        .WithOne(x => x.Task)
                        .HasForeignKey(x => x.TaskId);
            builder.HasMany(x => x.Comments)
                        .WithOne(x => x.Task)
                        .HasForeignKey(x => x.TaskId);
            builder.Property(x => x.Number)
                        .ValueGeneratedOnAdd();
            builder.Property(x => x.Code).HasMaxLength(200);
            builder.Property(x => x.StartDate)
                        .HasColumnType("DateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()")
                        .IsRequired();
            builder.Property(x => x.EndDate)
                        .HasColumnType("DateTime");
            base.Configure(builder);

            builder.HasOne(t => t.Closer)
                .WithMany(b => b.Tasks)
                .HasForeignKey(t => t.CloserId);

            builder.HasOne(t => t.Creater)
                .WithMany(b => b.Tasks)
                .HasForeignKey(t => t.CreaterId);

            builder.HasOne(t => t.Assignee)
                .WithMany(b => b.Tasks)
                .HasForeignKey(t => t.AssigneeId);
        }
    }
}
