using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class BlockHtmlCode : Entity
    {
        

        public int BlockId { get; set; }
        public Block? Block { get; set; }

        public string HtmlCode { get; set; }
    }
}
