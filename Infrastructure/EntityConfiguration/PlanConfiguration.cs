using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            
          builder
                .HasMany(p => p.Features)
                .WithOne(f => f.Plan)
                .HasForeignKey(f => f.PlanId);

            
            builder
                .HasMany(p => p.Orders)
                .WithOne(o => o.Plan)
                .HasForeignKey(o => o.PlanId);
        }
    }
}
