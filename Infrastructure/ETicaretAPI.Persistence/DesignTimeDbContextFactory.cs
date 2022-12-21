using ETicaretAPI.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ETicaretAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretAPIDbContext>
    {
        public ETicaretAPIDbContext CreateDbContext(string[] args)
        {
          

            DbContextOptionsBuilder<ETicaretAPIDbContext> dbContextOptionsBuilder = new();
            //dbContextOptionsBuilder.UseNpgsql("User Id=postgres;Password=postgrespw;Host=localhost;Port=49153;Database=postgres;");
            //return new(dbContextOptionsBuilder.Options);
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new ETicaretAPIDbContext(dbContextOptionsBuilder.Options);

        }
    }
}
