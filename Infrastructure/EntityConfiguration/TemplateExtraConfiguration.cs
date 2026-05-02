using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class TemplateExtraConfiguration : IEntityTypeConfiguration<TemplateExtra>
    {
        public void Configure(EntityTypeBuilder<TemplateExtra> builder)
        {
            builder.HasKey(x => new { x.TemplateId, x.ExtraId });

            builder.HasOne(x => x.Template)
                   .WithMany(t => t.TemplateExtras)
                   .HasForeignKey(x => x.TemplateId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Extra)
                   .WithMany(e => e.TemplateExtras)
                   .HasForeignKey(x => x.ExtraId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
