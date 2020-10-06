using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.Entities;

namespace TaskManagement.Entities
{
    public class Task : IEntity
    {
        public int Id { get ; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
        public string Code { get; set; }
        public int ReporterId { get; set; }
        public int AssigneeId { get; set; }
        public int CloserId { get; set; }
        public int ProjectId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreatedDate { get ; set ; }
        public DateTime? ModifiedDate { get; set ; }
        public bool? isActive { get ; set ; }

        public virtual User Reporter { get; set; }
        public virtual User Assignee { get; set; }
        public virtual User Closer { get; set; }
        public virtual Project Project { get; set; }
        public virtual IEnumerable<TaskProcess> TaskProcesses { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }
        public virtual IEnumerable<User> Users { get; set; }

        public virtual IEnumerable<Attachment> Attachments { get; set; }
    }
}
