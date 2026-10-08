using Microsoft.EntityFrameworkCore;
using PortfolioSite.Entities;

namespace PortfolioSite.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Project> Projects { get; set; }
        // İleride tablolarımızı (DbSet) buraya ekleyeceğiz.
    }
}
