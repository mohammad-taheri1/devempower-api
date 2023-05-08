using devempower_api.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace devempower_api.Core.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<VideoEntity> Videos { get; set; }
    }
}
