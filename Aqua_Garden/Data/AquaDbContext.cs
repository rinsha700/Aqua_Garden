using Aqua_Garden.Models;
using Microsoft.EntityFrameworkCore;

namespace Aqua_Garden.Data
{
    public class AquaDbContext:DbContext
    {
        public AquaDbContext(DbContextOptions<AquaDbContext> options) : base(options)
        {
        }
        public DbSet<Aqua> Fshes { get; set; }

    }
}
