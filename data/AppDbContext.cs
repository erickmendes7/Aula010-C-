    using Microsoft.EntityFrameworkCore;
    using aula10.models;

    namespace aula10.data;

    public class AppDbContext : DbContext
    {
    public AppDbContext(
    DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }
    public DbSet<Bolsista> Bolsistas { get; set; }
    }