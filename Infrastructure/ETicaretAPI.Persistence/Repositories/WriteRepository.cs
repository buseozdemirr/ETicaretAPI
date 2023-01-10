using ETicareAPI.Domain.Entities.Common;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ETicaretAPI.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity

    {
        private readonly ETicaretAPIDbContext _context;
        public WriteRepository(ETicaretAPIDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> entity)
        {
            await Table.AddRangeAsync(entity);
            return true;
        }

        public bool Remove(T entity)
        {
            EntityEntry<T> entityEntry = Table.Remove(entity);
            return entityEntry.State== EntityState.Deleted;

        }

        public async Task<bool> Remove(string id)

        {
           T model= await Table.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
            return Remove(model);
           
        }

        public bool RemoveRange(List<T> entities)
        {
           Table.RemoveRange(entities);
            return true;
        }

        public bool Update(T entity)
        {
            EntityEntry<T> entityEntry = Table.Update(entity);
            return entityEntry.State == EntityState.Modified;

        }
        public async Task<int> SaveAsync()
       => await _context.SaveChangesAsync();

      
    }
}
