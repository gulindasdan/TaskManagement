using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.DataAccess.EntityFramework;
using TaskManagement.DataAccess.Abstract;
using TaskManagement.DataAccess.Context;
using TaskManagement.Entities;

namespace TaskManagement.DataAccess.Concrete
{
    public class TaskRepository : EfRepositoryBase<Task, TaskManagementDbContext>, ITaskRepository
    {
        public TaskRepository(TaskManagementDbContext context) : base(context)
        {
        }
    }
}
