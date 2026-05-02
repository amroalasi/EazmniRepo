using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class OrderFormFieldValueConfiguration : IEntityTypeConfiguration<OrderFormFieldValue>
    {
        public void Configure(EntityTypeBuilder<OrderFormFieldValue> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Order)
                   .WithMany(o => o.FormFieldValues)
                   .HasForeignKey(x => x.OrderId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.FormField)
                   .WithMany(f => f.Values)
                   .HasForeignKey(x => x.FormFieldId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
