﻿using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.Entities;

namespace TaskManagement.Entities
{
    public class History : IEntity
    {
        public int Id { get ; set ; }
        public int UserId { get; set; }
        public int TaskId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime CreatedDate { get ; set ; }
        public DateTime? ModifiedDate { get ; set ; }
        public bool? IsActive { get ; set ; }

        public virtual User User { get; set; }
        public virtual Task Task { get; set; }
    }
}
