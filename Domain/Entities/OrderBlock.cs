using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class OrderBlock : JunctionTabel
    {
        

        public int OrderId { get; set; }
        public Order? Order { get; set; }

        public int BlockId { get; set; }
        public Block? Block { get; set; }

        public decimal Price { get; set; }
    }
}
