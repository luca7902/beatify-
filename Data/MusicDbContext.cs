using Microsoft.EntityFrameworkCore;
using MusikPlayer.Models;

namespace MusikPlayer.Data
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext(DbContextOptions<MusicDbContext> options)
            : base(options)
        {

        }

        public DbSet<Beat> Beats { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
