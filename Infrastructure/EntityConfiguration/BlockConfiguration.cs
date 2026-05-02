using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class BlockConfiguration : IEntityTypeConfiguration<Block>
    {
        public void Configure(EntityTypeBuilder<Block> builder)
        {
            builder.HasMany(b => b.TemplateBlocks)
             .WithOne(tb => tb.Block)
             .HasForeignKey(tb => tb.BlockId);

            builder.HasMany(b => b.FormFields)
                   .WithOne(f => f.Block)
                   .HasForeignKey(f => f.BlockId);

            builder.HasMany(b => b.OrderBlocks)
                   .WithOne(ob => ob.Block)
                   .HasForeignKey(ob => ob.BlockId);

            builder.HasOne(b => b.HtmlCode)
                   .WithOne(h => h.Block)
                   .HasForeignKey<BlockHtmlCode>(h => h.BlockId);
        }
    }
}
