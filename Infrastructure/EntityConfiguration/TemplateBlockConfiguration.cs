using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class TemplateBlockConfiguration : IEntityTypeConfiguration<TemplateBlock>
    {
        public void Configure(EntityTypeBuilder<TemplateBlock> builder)
        {
            builder.HasKey(x => new { x.TemplateId, x.BlockId });

            builder.HasOne(x => x.Template)
                   .WithMany(t => t.TemplateBlocks)
                   .HasForeignKey(x => x.TemplateId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Block)
                   .WithMany(b => b.TemplateBlocks)
                   .HasForeignKey(x => x.BlockId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
