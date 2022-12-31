using ETicareAPI.Domain.Entities.Common;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Task<bool> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddAsync(List<T> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
