namespace WorldCitiesAPI.Data;

using Microsoft.EntityFrameworkCore;
using Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() : base()
    {
    }
    
    public ApplicationDbContext(DbContextOptions options): base(options)
    {
    }
    
    public DbSet<City> Cities => Set<City>();
    public DbSet<Country> Countries => Set<Country>();
}