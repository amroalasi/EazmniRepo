using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.ApplicationDBcontext
{
    public class EazmniContext(DbContextOptions<EazmniContext>option):DbContext(option)
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
            foreach (var fk in modelBuilder.Model.GetEntityTypes()
                     .SelectMany(e => e.GetForeignKeys()))
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }
            // Plan -> PlanFeatures (One To Many)
            modelBuilder.Entity<Plan>()
                .HasMany(p => p.Features)
                .WithOne(f => f.Plan)
                .HasForeignKey(f => f.PlanId);

            // Plan -> Orders (One To Many)
            modelBuilder.Entity<Plan>()
                .HasMany(p => p.Orders)
                .WithOne(o => o.Plan)
                .HasForeignKey(o => o.PlanId);

            // User -> Orders (One To Many)
            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId);

            // Tag -> Templates (One To Many)
            modelBuilder.Entity<Tag>()
                .HasMany(t => t.Templates)
                .WithOne(t => t.Tag)
                .HasForeignKey(t => t.TagId);

            // Template -> Orders (One To Many)
            modelBuilder.Entity<Template>()
                .HasMany(t => t.Orders)
                .WithOne(o => o.Template)
                .HasForeignKey(o => o.TemplateId);

            // Template -> TemplateBlocks (One To Many)
            modelBuilder.Entity<Template>()
                .HasMany(t => t.TemplateBlocks)
                .WithOne(tb => tb.Template)
                .HasForeignKey(tb => tb.TemplateId);

            // Block -> TemplateBlocks (One To Many)
            modelBuilder.Entity<Block>()
                .HasMany(b => b.TemplateBlocks)
                .WithOne(tb => tb.Block)
                .HasForeignKey(tb => tb.BlockId);

            // Template -> TemplateLanguages (One To Many)
            modelBuilder.Entity<Template>()
                .HasMany(t => t.TemplateLanguages)
                .WithOne(tl => tl.Template)
                .HasForeignKey(tl => tl.TemplateId);

            // Language -> TemplateLanguages (One To Many)
            modelBuilder.Entity<Language>()
                .HasMany(l => l.TemplateLanguages)
                .WithOne(tl => tl.Language)
                .HasForeignKey(tl => tl.LanguageId);

            // Template -> TemplateExtras (One To Many)
            modelBuilder.Entity<Template>()
                .HasMany(t => t.TemplateExtras)
                .WithOne(te => te.Template)
                .HasForeignKey(te => te.TemplateId);

            // Extra -> TemplateExtras (One To Many)
            modelBuilder.Entity<Extra>()
                .HasMany(e => e.TemplateExtras)
                .WithOne(te => te.Extra)
                .HasForeignKey(te => te.ExtraId);

            // Block -> FormFields (One To Many)
            modelBuilder.Entity<Block>()
                .HasMany(b => b.FormFields)
                .WithOne(f => f.Block)
                .HasForeignKey(f => f.BlockId);

            // Extra -> FormFields (One To Many)
            modelBuilder.Entity<Extra>()
                .HasMany(e => e.FormFields)
                .WithOne(f => f.Extra)
                .HasForeignKey(f => f.ExtraId);

            // FormField -> FormFieldOptions (One To Many)
            modelBuilder.Entity<FormField>()
                .HasMany(f => f.Options)
                .WithOne(o => o.Field)
                .HasForeignKey(o => o.FieldId);

            // FormField -> OrderFormFieldValues (One To Many)
            modelBuilder.Entity<FormField>()
                .HasMany(f => f.Values)
                .WithOne(v => v.FormField)
                .HasForeignKey(v => v.FormFieldId);

            // Order -> OrderLanguages (One To Many)
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderLanguages)
                .WithOne(ol => ol.Order)
                .HasForeignKey(ol => ol.OrderId);

            // Language -> OrderLanguages (One To Many)
            modelBuilder.Entity<Language>()
                .HasMany(l => l.OrderLanguages)
                .WithOne(ol => ol.Language)
                .HasForeignKey(ol => ol.LanguageId);

            // Order -> OrderBlocks (One To Many)
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderBlocks)
                .WithOne(ob => ob.Order)
                .HasForeignKey(ob => ob.OrderId);

            // Block -> OrderBlocks (One To Many)
            modelBuilder.Entity<Block>()
                .HasMany(b => b.OrderBlocks)
                .WithOne(ob => ob.Block)
                .HasForeignKey(ob => ob.BlockId);

            // Order -> OrderExtras (One To Many)
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderExtras)
                .WithOne(oe => oe.Order)
                .HasForeignKey(oe => oe.OrderId);

            // Extra -> OrderExtras (One To Many)
            modelBuilder.Entity<Extra>()
                .HasMany(e => e.OrderExtras)
                .WithOne(oe => oe.Extra)
                .HasForeignKey(oe => oe.ExtraId);

            // Order -> OrderFormFieldValues (One To Many)
            modelBuilder.Entity<Order>()
                .HasMany(o => o.FormFieldValues)
                .WithOne(v => v.Order)
                .HasForeignKey(v => v.OrderId);

            // Order -> Guests (One To Many)
            modelBuilder.Entity<Order>()
                .HasMany(o => o.Guests)
                .WithOne(g => g.Order)
                .HasForeignKey(g => g.OrderId);

            // Block -> BlockHtmlCode (One To One)
            modelBuilder.Entity<Block>()
                .HasOne(b => b.HtmlCode)
                .WithOne(h => h.Block)
                .HasForeignKey<BlockHtmlCode>(h => h.BlockId);
        }
    }
}
