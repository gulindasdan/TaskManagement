using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.DataAccess.EntityFramework;
using TaskManagement.DataAccess.Abstract;
using TaskManagement.DataAccess.Context;
using TaskManagement.Entities;

namespace TaskManagement.DataAccess.Concrete
{
    public class ProjectRepository : EfRepositoryBase<Project, TaskManagementDbContext>, IProjectRepository
    {
        public ProjectRepository(TaskManagementDbContext context) : base(context)
        {
        }
    }
}
