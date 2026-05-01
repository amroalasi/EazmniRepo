using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class User : AuditTable
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}
