using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public string? CreatedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }   
        public string? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
