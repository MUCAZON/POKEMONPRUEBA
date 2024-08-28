using Microsoft.EntityFrameworkCore;
using POKEMONPRUEBA.Modelo;

namespace POKEMONPRUEBA.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Pokemon> Pokemons { get; set; }
    }
}
