using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.Entities;

namespace TaskManagement.Entities
{
    public class Process : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual IEnumerable<ProcessStatus> ProcessStatuses { get; set; }
        public virtual IEnumerable<TaskProcess> TaskProcesses { get; set; }
    }
}
