using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class ExtraConfiguration : IEntityTypeConfiguration<Extra>
    {
        public void Configure(EntityTypeBuilder<Extra> builder)
        {
            builder.HasMany(e => e.TemplateExtras)
               .WithOne(te => te.Extra)
               .HasForeignKey(te => te.ExtraId);

            builder.HasMany(e => e.FormFields)
                   .WithOne(f => f.Extra)
                   .HasForeignKey(f => f.ExtraId);

            builder.HasMany(e => e.OrderExtras)
                   .WithOne(oe => oe.Extra)
                   .HasForeignKey(oe => oe.ExtraId);
        }
    }
}
