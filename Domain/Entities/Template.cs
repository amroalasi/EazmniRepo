using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Template : Entity
    {
       
        public string Name { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }
        public string ImageUrl { get; set; }

        public int TagId { get; set; }
        public Tag? Tag { get; set; }

        public ICollection<TemplateBlock>? TemplateBlocks { get; set; } 
        public ICollection<TemplateLanguage>? TemplateLanguages { get; set; }
        public ICollection<TemplateExtra>? TemplateExtras { get; set; } 
        public ICollection<Order>? Orders { get; set; } 
    }
}
