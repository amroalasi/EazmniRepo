using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class CommonQuestionConfiguration : IEntityTypeConfiguration<CommonQuestion>
    {
        public void Configure(EntityTypeBuilder<CommonQuestion> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
