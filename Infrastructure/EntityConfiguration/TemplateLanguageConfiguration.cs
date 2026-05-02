using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class TemplateLanguageConfiguration : IEntityTypeConfiguration<TemplateLanguage>
    {
        public void Configure(EntityTypeBuilder<TemplateLanguage> builder)
        {
            builder.HasKey(x => new { x.TemplateId, x.LanguageId });

            builder.HasOne(x => x.Template)
                   .WithMany(t => t.TemplateLanguages)
                   .HasForeignKey(x => x.TemplateId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Language)
                   .WithMany(l => l.TemplateLanguages)
                   .HasForeignKey(x => x.LanguageId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
