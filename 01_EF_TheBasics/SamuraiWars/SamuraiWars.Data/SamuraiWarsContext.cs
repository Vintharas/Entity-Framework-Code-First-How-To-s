using System.Data.Entity;
using SamuraiWars.Model;

namespace SamuraiWars.Data
{
    public class SamuraiWarsContext : DbContext
    {
        public DbSet<Castle> Castles { get; set; }
        public DbSet<Samurai> Samurai { get; set; }
    }
}
