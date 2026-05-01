using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class TemplateBlock: Entity
    {
       

        public int TemplateId { get; set; }
        public Template Template { get; set; }

        public int BlockId { get; set; }
        public Block? Block { get; set; }
    }
}
