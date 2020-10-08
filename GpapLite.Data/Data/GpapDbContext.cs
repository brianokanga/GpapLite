using GpapLite.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GpapLite.Data.Data
{
    public class GpapDbContext : DbContext
    {
        public GpapDbContext(DbContextOptions<GpapDbContext> options)
            : base(options)
        {
        }



     
        public DbSet<County> Counties { get; set; }
        public DbSet<SubCounty> SubCounties { get; set; }
    }
}
