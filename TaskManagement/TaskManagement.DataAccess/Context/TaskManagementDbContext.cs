using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TaskManagement.Entities;

namespace TaskManagement.DataAccess.Context
{
    public class TaskManagementDbContext : DbContext
    {
        public TaskManagementDbContext(){}
        public TaskManagementDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<BusinessAnalyst> BusinessAnalysts { get; set; }
    }
}
