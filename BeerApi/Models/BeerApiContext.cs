using Microsoft.EntityFrameworkCore;

namespace BeerApi.Models
{
  public class BeerApiContext : DbContext
  {
    public BeerApiContext(DbContextOptions<BeerApiContext> options) : base(options)
    {

    }
    public DbSet<Beer> Beers { get; set; }
  }
}