using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class OrderExtra : Entity
    {
     

        public int OrderId { get; set; }
        public Order? Order { get; set; }

        public int ExtraId { get; set; }
        public Extra? Extra { get; set; }

        public decimal Price { get; set; }
    }


}
