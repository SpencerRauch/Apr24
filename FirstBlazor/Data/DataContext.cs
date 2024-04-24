using Microsoft.EntityFrameworkCore;
using FirstBlazor.Entity;
namespace FirstBlazor.Data;

public class DataContext:DbContext
{
    public DataContext(DbContextOptions options) : base(options){}
    public DbSet<Game> Games { get;set; }
}