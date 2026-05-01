using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Order : Entity
    {


        public int? UserId { get; set; }
        public User? User { get; set; }

        public int? PlanId { get; set; }
        public Plan? Plan { get; set; }

        public int? TemplateId { get; set; }
        public Template? Template { get; set; }

        public string PartnerName { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantPhone { get; set; }
        public string ApplicantEmail { get; set; }

        public DateTime WeddingDate { get; set; }

        public ICollection<OrderLanguage>? OrderLanguages { get; set; }
        public ICollection<OrderBlock>? OrderBlocks { get; set; }
        public ICollection<OrderExtra>? OrderExtras { get; set; }
        public ICollection<OrderFormFieldValue>? FormFieldValues { get; set; }
        public ICollection<OrderGuest>? Guests { get; set; }
    }
}