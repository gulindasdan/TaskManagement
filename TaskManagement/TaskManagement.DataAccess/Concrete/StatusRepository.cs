using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.DataAccess.EntityFramework;
using TaskManagement.DataAccess.Abstract;
using TaskManagement.DataAccess.Context;
using TaskManagement.Entities;

namespace TaskManagement.DataAccess.Concrete
{
    public class StatusRepository : EfRepositoryBase<Status, TaskManagementDbContext>, IStatusRepository
    {
        public StatusRepository(TaskManagementDbContext context) : base(context)
        {
        }
    }
}
