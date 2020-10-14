using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.DataAccess.EntityFramework;
using TaskManagement.DataAccess.Abstract;
using TaskManagement.DataAccess.Context;
using TaskManagement.Entities;

namespace TaskManagement.DataAccess.Concrete
{
    public class CommentRepository : EfRepositoryBase<Comment, TaskManagementDbContext>, ICommentRepository
    {
        public CommentRepository(TaskManagementDbContext context) : base(context)
        {
        }
    }
}
