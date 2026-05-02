using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class PlanFeatureConfiguration : IEntityTypeConfiguration<PlanFeature>
    {
        public void Configure(EntityTypeBuilder<PlanFeature> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Plan)
                   .WithMany(p => p.Features)
                   .HasForeignKey(x => x.PlanId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
