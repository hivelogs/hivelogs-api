using Microsoft.EntityFrameworkCore;

namespace Hivelogs.Infrastructure.Persistence.Context
{
    public class HivelogsDbContext(DbContextOptions<HivelogsDbContext> options) : DbContext(options) 
    {
    }
}
