using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Tag:AuditTable
    {
        
        public string Name { get; set; }

        public ICollection<Template>? Templates { get; set; }
    }
}
