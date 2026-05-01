using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class Extra : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Icon { get; set; }

        public ICollection<TemplateExtra>? TemplateExtras { get; set; } 
        public ICollection<FormField>? FormFields { get; set; } 
        public ICollection<OrderExtra>? OrderExtras { get; set; } 
    }
}
