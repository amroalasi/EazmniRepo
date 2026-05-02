using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasMany(o => o.OrderLanguages)
               .WithOne(ol => ol.Order)
               .HasForeignKey(ol => ol.OrderId);

            builder.HasMany(o => o.OrderBlocks)
                   .WithOne(ob => ob.Order)
                   .HasForeignKey(ob => ob.OrderId);

            builder.HasMany(o => o.OrderExtras)
                   .WithOne(oe => oe.Order)
                   .HasForeignKey(oe => oe.OrderId);

            builder.HasMany(o => o.FormFieldValues)
                   .WithOne(v => v.Order)
                   .HasForeignKey(v => v.OrderId);

            builder.HasMany(o => o.Guests)
                   .WithOne(g => g.Order)
                   .HasForeignKey(g => g.OrderId);
        }
    }
}
