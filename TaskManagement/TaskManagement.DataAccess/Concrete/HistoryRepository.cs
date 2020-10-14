using TaskManagement.Core.DataAccess.EntityFramework;
using TaskManagement.DataAccess.Abstract;
using TaskManagement.DataAccess.Context;
using TaskManagement.Entities;

namespace TaskManagement.DataAccess.Concrete
{
    public class HistoryRepository : EfRepositoryBase<History, TaskManagementDbContext>, IHistoryRepository
    {
        public HistoryRepository(TaskManagementDbContext context) : base(context)
        {
        }
    }
}
