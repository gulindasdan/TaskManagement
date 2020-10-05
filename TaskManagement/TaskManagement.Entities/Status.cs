using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.Entities;

namespace TaskManagement.Entities
{
    public class Status : IEntity
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get ; set ; }
        public DateTime? ModifiedDate { get ; set ; }
        public bool? isActive { get ; set ; }

        public virtual IEnumerable<ProcessStatus> ProcessStatuses { get; set; }
        public virtual IEnumerable<ProjectStatus> ProjectStatuses { get; set; }
    }
}
