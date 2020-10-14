using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.DataAccess;
using TaskManagement.Entities;

namespace TaskManagement.DataAccess.Abstract
{
    public interface ITaskRepository : IRepository<Task>
    {
    }
}
