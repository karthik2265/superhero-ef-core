using Microsoft.EntityFrameworkCore;
using SuperHeroes.models;

namespace SuperHeroes.Data;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options): base(options) { }

    public DbSet<SuperHero> SuperHeroes { get; set; }
}
