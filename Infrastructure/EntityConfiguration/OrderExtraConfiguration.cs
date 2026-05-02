using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class OrderExtraConfiguration : IEntityTypeConfiguration<OrderExtra>
    {
        public void Configure(EntityTypeBuilder<OrderExtra> builder)
        {

            builder.HasKey(x => new { x.OrderId, x.ExtraId });

            builder.HasOne(x => x.Order)
                   .WithMany(o => o.OrderExtras)
                   .HasForeignKey(x => x.OrderId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Extra)
                   .WithMany(e => e.OrderExtras)
                   .HasForeignKey(x => x.ExtraId)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
