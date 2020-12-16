using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Services
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Artwork> Artworks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
