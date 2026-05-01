using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Block : Entity
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public ICollection<TemplateBlock>? TemplateBlocks { get; set; } 
        public ICollection<FormField>? FormFields { get; set; }
        public ICollection<OrderBlock>? OrderBlocks { get; set; } 

        public BlockHtmlCode? HtmlCode { get; set; }
    }
}
