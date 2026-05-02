using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            
            builder
                .HasMany(t => t.Templates)
                .WithOne(t => t.Tag)
                .HasForeignKey(t => t.TagId);
        }
    }
}
