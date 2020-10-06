using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.Entities;

namespace TaskManagement.Entities
{
    public class User : IEntity
    {
        public int Id { get; set ; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? CreatedDate { get ; set ; }
        public DateTime? ModifiedDate { get ; set ; }
        public bool? isActive { get ; set ; }

        public virtual IEnumerable<Comment> Comments { get; set; }
        public virtual IEnumerable<Task> Tasks { get; set; }
        public virtual IEnumerable<History> Histories { get; set; }
    }
}
