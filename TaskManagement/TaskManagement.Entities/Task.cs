using System;
using System.Collections.Generic;
using TaskManagement.Core.Entities;

namespace TaskManagement.Entities
{
    public class Task : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
        public string Code { get; set; }
        public int CreaterId { get; set; }
        public int AssigneeId { get; set; }
        public int CloserId { get; set; }
        public int ProjectId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }

        public Creater Creater { get; set; }
        public Assigne Assignee { get; set; }
        public BusinessAnalyst Closer { get; set; }
        public Project Project { get; set; }
        public virtual IEnumerable<TaskProcess> TaskProcesses { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }
        public virtual IEnumerable<User> Viewers { get; set; }

        public virtual IEnumerable<Attachment> Attachments { get; set; }
    }
}
