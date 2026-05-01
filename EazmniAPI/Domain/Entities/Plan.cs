using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Plan:AuditTable
    {
        
        public string Title { get; set; }
        public decimal Price { get; set; }
        public decimal PriceAfterDiscount { get; set; }
        public string Description { get; set; }
        public int Popularity { get; set; }

        public ICollection<PlanFeature>? Features { get; set; } 
        public ICollection<Order>? Orders { get; set; } 
    }
}
