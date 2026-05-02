using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class TemplateExtra: JunctionTabel
    {


        public int TemplateId { get; set; }
        public Template Template { get; set; }

        public int ExtraId { get; set; }
        public Extra? Extra { get; set; }
    }
}
