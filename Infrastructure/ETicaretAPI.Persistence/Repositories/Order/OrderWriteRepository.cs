using ETicareAPI.Domain.Entities;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Infrastructure.Contexts;


namespace ETicaretAPI.Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
