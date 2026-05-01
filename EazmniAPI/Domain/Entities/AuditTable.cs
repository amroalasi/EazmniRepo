using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public abstract class AuditTable
    {
        public int Id { get; set; }

        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
