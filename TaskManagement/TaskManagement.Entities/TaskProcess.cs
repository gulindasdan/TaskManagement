using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.Entities;

namespace TaskManagement.Entities
{
    public class TaskProcess : IEntity
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int ProcessId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? isActive { get; set; }

        public virtual Task Task { get; set; }
        public virtual Process Process { get; set; }
       
    }
}
