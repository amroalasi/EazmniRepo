using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class BlockHtmlCodeConfiguration : IEntityTypeConfiguration<BlockHtmlCode>
    {
        public void Configure(EntityTypeBuilder<BlockHtmlCode> builder)
        {
            builder.HasKey(h => h.BlockId); 
            builder.HasOne(h => h.Block)
                   .WithOne(b => b.HtmlCode)
                   .HasForeignKey<BlockHtmlCode>(h => h.BlockId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
