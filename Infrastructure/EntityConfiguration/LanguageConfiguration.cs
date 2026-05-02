using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasMany(l => l.TemplateLanguages)
              .WithOne(tl => tl.Language)
              .HasForeignKey(tl => tl.LanguageId);

            builder.HasMany(l => l.OrderLanguages)
                   .WithOne(ol => ol.Language)
                   .HasForeignKey(ol => ol.LanguageId);
        }
    }
}
