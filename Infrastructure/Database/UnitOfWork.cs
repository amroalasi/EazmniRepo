using Application.Abstraction;
using Domain.Entities;
using Infrastructure.ApplicationDBcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Database
{
    public  class UnitOfWork (EazmniContext context ) : IUnitOfWork
    {  
      
        public async Task<int> savechangesAsync(CancellationToken cancellationToken = default)
        {
           
            IEnumerable<EntityEntry> entries = context
            .ChangeTracker
            .Entries()
            .Where(e => e.State == EntityState.Added ||
                        e.State == EntityState.Modified);

            foreach (EntityEntry entry in entries)
            {
                var entity = (Entity)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedBy = " ";
                    entity.CreatedAt = DateTime.UtcNow;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entity.ModifiedBy = " ";
                    entity.ModifiedAt = DateTime.UtcNow;
                }
            }

            int  result  =  await context.SaveChangesAsync(cancellationToken);

            return result;
        }
    }
}
