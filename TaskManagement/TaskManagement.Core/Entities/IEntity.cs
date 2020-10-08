using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TaskManagement.Core.Entities
{
    public interface IEntity : IEntity<int> { }
    public interface IEntity<TKey>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        TKey Id { get; set; }
        DateTime CreatedDate { get; set; }

        DateTime? ModifiedDate { get; set; }
        bool IsActive { get; set; }
        
    }
}

