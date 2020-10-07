using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace GpapLite.Data.Data
{
    public class GpapDbContext : DbContext
    {
        public GpapDbContext(DbContextOptions<GpapDbContext> options)
            : base(options)
        {
        }
    }
}
