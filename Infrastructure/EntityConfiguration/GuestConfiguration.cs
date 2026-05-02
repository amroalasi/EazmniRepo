using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

public class GuestConfiguration : IEntityTypeConfiguration<OrderGuest>
{
    public void Configure(EntityTypeBuilder<OrderGuest> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Order)
               .WithMany(o => o.Guests)
               .HasForeignKey(x => x.OrderId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
