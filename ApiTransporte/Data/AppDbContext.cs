using ApiTransporte.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTransporte.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Vehiculo> Vehiculo { get; set; }
    }
}
