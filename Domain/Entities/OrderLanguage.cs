using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class OrderLanguage : Entity
    {
       

        public int OrderId { get; set; }
        public Order? Order { get; set; }

        public int LanguageId { get; set; }
        public Language? Language { get; set; }

        public decimal Price { get; set; }
    }
}
