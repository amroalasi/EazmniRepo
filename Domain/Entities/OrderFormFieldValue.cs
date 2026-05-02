using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class OrderFormFieldValue : JunctionTabel
    {
        

        public int OrderId { get; set; }
        public Order? Order { get; set; }

        public int FormFieldId { get; set; }
        public FormField? FormField { get; set; }

        public string Value { get; set; }
    }
}
