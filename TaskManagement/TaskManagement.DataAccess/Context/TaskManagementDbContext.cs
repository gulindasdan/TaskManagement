using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using TaskManagement.Entities;

namespace TaskManagement.DataAccess.Context
{
    public class TaskManagementDbContext : IdentityDbContext<AppUser>
    {
        public TaskManagementDbContext() { }
        public TaskManagementDbContext(DbContextOptions<TaskManagementDbContext> options) : base(options) { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder builder)
        //{
        //    if (!builder.IsConfigured)
        //    {
        //        IConfigurationRoot configuration = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile(@Directory.GetCurrentDirectory() + "/../TaskManagement.API/appsettings.json")
        //        .Build();
        //        var connectionString = configuration.GetConnectionString("DefaultConnectionString");
        //        builder.UseSqlServer(connectionString);
        //    }

        //    base.OnConfiguring(builder);
        //}

    }
}
