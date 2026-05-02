using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class OrderLanguageConfiguration : IEntityTypeConfiguration<OrderLanguage>
    {
        public void Configure(EntityTypeBuilder<OrderLanguage> builder)
        {
            builder.HasKey(x => new { x.OrderId, x.LanguageId });

            builder.HasOne(x => x.Order)
                   .WithMany(o => o.OrderLanguages)
                   .HasForeignKey(x => x.OrderId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Language)
                   .WithMany(l => l.OrderLanguages)
                   .HasForeignKey(x => x.LanguageId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
