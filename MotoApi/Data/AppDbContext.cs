using Microsoft.EntityFrameworkCore;
using MotoApi.Models;

namespace MotoApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<Galpao> Galpoes => Set<Galpao>();
    public DbSet<Area> Areas => Set<Area>();
    public DbSet<Corredor> Corredores => Set<Corredor>();
    public DbSet<Vaga> Vagas => Set<Vaga>();
    public DbSet<Moto> Motos => Set<Moto>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // ...configurações de relacionamento e constraints...
    }
}
