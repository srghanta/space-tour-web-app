
using Microsoft.EntityFrameworkCore;
using SpaceTourAPI.Models;

namespace SpaceTourAPI.Data
{
    public class SpaceTourContext : DbContext
    {
        public SpaceTourContext(DbContextOptions<SpaceTourContext> options) : base(options) { }
        public DbSet<Tour> Tours { get; set; }
    }
}
