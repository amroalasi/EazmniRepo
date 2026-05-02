using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class TemplateLanguage: JunctionTabel
    {
        public int TemplateId { get; set; }
        public Template? Template { get; set; }

        public int LanguageId { get; set; }
        public Language? Language { get; set; }
    }
}
