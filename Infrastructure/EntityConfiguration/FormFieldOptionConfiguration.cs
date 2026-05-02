using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class FormFieldOptionConfiguration : IEntityTypeConfiguration<FormFieldOption>
    {
        public void Configure(EntityTypeBuilder<FormFieldOption> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Field)
                   .WithMany(f => f.Options)
                   .HasForeignKey(x => x.FieldId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
