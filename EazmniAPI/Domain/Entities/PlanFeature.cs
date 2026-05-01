using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PlanFeature :AuditTable
    {
      
        public int PlanId { get; set; }
        public string Name { get; set; }
        public Plan? Plan { get; set; }
    }
}
