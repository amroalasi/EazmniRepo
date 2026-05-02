using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class OrderBlockConfiguration : IEntityTypeConfiguration<OrderBlock>
    {
        public void Configure(EntityTypeBuilder<OrderBlock> builder)
        {
            builder.HasKey(x => new { x.OrderId, x.BlockId });

            builder.HasOne(x => x.Order)
                   .WithMany(o => o.OrderBlocks)
                   .HasForeignKey(x => x.OrderId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Block)
                   .WithMany(b => b.OrderBlocks)
                   .HasForeignKey(x => x.BlockId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
