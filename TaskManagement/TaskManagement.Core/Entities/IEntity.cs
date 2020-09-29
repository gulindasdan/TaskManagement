using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.Core.Entities
{
    public interface IEntity : IEntity<int> { }
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
        DateTime? CreatedDate { get; set; }

        DateTime? ModifiedDate { get; set; }
        bool? isActive { get; set; }
        
    }
}

