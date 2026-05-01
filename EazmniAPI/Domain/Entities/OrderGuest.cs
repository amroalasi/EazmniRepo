using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class OrderGuest :AuditTable
    {
      

        public int OrderId { get; set; }
        public Order? Order { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public bool AttendanceConfirmation { get; set; }
        public bool IsNeedTransportation { get; set; }

        public string Message { get; set; }
    }
}
