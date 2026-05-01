using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class FormFieldOption : Entity
    {
        

        public int FieldId { get; set; }
        public FormField? Field { get; set; }

        public string OptionLabel { get; set; }
        public string OptionValue { get; set; }
        public int DisplayOrder { get; set; }
    }
}
