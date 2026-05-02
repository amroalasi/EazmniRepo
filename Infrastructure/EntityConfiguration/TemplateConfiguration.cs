using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class TemplateConfiguration : IEntityTypeConfiguration<Template>
    {
        public void Configure(EntityTypeBuilder<Template> builder)
        {
            builder.HasMany(t => t.Orders)
        .WithOne(o => o.Template)
        .HasForeignKey(o => o.TemplateId)
        .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(t => t.TemplateBlocks)
                   .WithOne(tb => tb.Template)
                   .HasForeignKey(tb => tb.TemplateId);

            builder.HasMany(t => t.TemplateLanguages)
                   .WithOne(tl => tl.Template)
                   .HasForeignKey(tl => tl.TemplateId);

            builder.HasMany(t => t.TemplateExtras)
                   .WithOne(te => te.Template)
                   .HasForeignKey(te => te.TemplateId);
        }
    }
}
