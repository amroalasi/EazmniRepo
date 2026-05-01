using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Language : Entity
    {
        
        public string Code { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Tag { get; set; }
        public decimal Price { get; set; }

        public ICollection<TemplateLanguage> TemplateLanguages { get; set; }
        public ICollection<OrderLanguage> OrderLanguages { get; set; }
    }
}
