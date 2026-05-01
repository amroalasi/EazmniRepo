using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class FormField : Entity
    {
        

        public int? BlockId { get; set; }
        public Block? Block { get; set; }

        public int? ExtraId { get; set; }
        public Extra? Extra { get; set; }

        public string FieldName { get; set; }
        public string Label { get; set; }
        public string FieldType { get; set; }
        public string Placeholder { get; set; }
        public bool IsRequired { get; set; }
        public int DisplayOrder { get; set; }

        public ICollection<FormFieldOption>? Options { get; set; }
        public ICollection<OrderFormFieldValue>? Values { get; set; }
    }
}
