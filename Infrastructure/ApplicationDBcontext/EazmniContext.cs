using Audit.EntityFramework;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.ApplicationDBcontext
{
    public class EazmniContext(DbContextOptions<EazmniContext> option) :  DbContext(option)
    {
        public DbSet<User>Users { get; set; }
        public DbSet<TemplateLanguage>templateLanguages { get; set; }
        public DbSet<TemplateExtra>templateExtras { get; set; }
        public DbSet<TemplateBlock> templateBlocks { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<Tag>tags { get; set; }
        public DbSet<PlanFeature>planFeatures { get; set; }
        public DbSet<Plan>plans { get; set; }
        public DbSet<OrderLanguage>orderLanguages { get; set; }
        public DbSet<OrderGuest>orderGuests { get; set; }
        public DbSet<OrderFormFieldValue> orderFormFields { get; set; }
        public DbSet<OrderExtra>orderExtras { get; set; }
        public DbSet<OrderBlock> orderBlocks { get; set; }
        public DbSet<Order>orders { get; set; }
        public DbSet<Language>languages { get; set; }
        public DbSet<FormFieldOption>formFieldOptions { get; set; }
        public DbSet<FormField>formFields { get; set; }
        public DbSet<Extra>extras { get; set; }
        public DbSet<CommonQuestion>commonQuestions { get; set; }
        public DbSet<BlockHtmlCode>blockHtmlCodes { get; set; }
        public DbSet<Block>blocks { get; set; }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EazmniContext).Assembly);
        }
    }
}
