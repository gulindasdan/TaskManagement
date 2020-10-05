using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.Entities;

namespace TaskManagement.Entities
{
    public class Project : IEntity
    {
        public int Id { get; set ; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreaterId { get; set; }
        public int CloserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreatedDate { get ; set ; }
        public DateTime? ModifiedDate { get ; set ; }
        public bool? isActive { get ; set ; }

        public virtual User Creater { get; set; }
        public virtual User Closer { get; set; }
        public virtual IEnumerable<Task> Tasks { get; set; }
        public virtual IEnumerable<ProjectStatus> ProjectStatuses { get; set; }
    }
}
