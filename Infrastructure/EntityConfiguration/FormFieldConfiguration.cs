using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class FormFieldConfiguration : IEntityTypeConfiguration<FormField>
    {
        public void Configure(EntityTypeBuilder<FormField> builder)
        {
            builder.HasMany(f => f.Options)
              .WithOne(o => o.Field)
              .HasForeignKey(o => o.FieldId);

            builder.HasMany(f => f.Values)
                   .WithOne(v => v.FormField)
                   .HasForeignKey(v => v.FormFieldId);
        }
    }
}
