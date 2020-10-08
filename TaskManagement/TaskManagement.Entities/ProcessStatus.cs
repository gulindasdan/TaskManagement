using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.Entities;

namespace TaskManagement.Entities
{
    public class ProcessStatus : IEntity
    {
        public int Id { get; set; }
        public int ProcessId { get; set; }
        public int StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get ; set ; }
        public virtual Process Process { get; set; }
        public virtual Status Status { get; set; }
    }
}
