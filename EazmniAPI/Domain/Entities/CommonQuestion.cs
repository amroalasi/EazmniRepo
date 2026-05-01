using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class CommonQuestion : AuditTable
    {
     
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
