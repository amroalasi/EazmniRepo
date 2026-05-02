using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class JunctionTabel
    {
        public DateTime CreatedAt { get; set; }
        public string? CreatedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
