using Microsoft.EntityFrameworkCore;

namespace BeerApi.Models
{
  public class BeerApiContext : DbContext
  {
    public BeerApiContext(DbContextOptions<BeerApiContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Beer>()
        .HasData(
          new Beer { BeerId = 1, Name = "Sticky Hands", Brewery = "Block15", Style = "IPA", Abv = 8.1 },
          new Beer { BeerId = 2, Name = "Hell", Brewery = "Wayfinder", Style = "Lager", Abv = 4.8 },
          new Beer { BeerId = 3, Name = "Guinness", Brewery = "Guinness", Style = "Stout", Abv = 4.2 },
          new Beer { BeerId = 4, Name = "Blueberry Muffin", Brewery = "Great Notion", Style = "Sour", Abv = 6 },
          new Beer { BeerId = 5, Name = "Blue Moon", Brewery = "Blue Moon", Style = "Wheat", Abv = 5 },
          new Beer { BeerId = 6, Name = "Corona", Brewery = "Corona", Style = "Lager", Abv = 4.5 },
          new Beer { BeerId = 7, Name = "Ripe", Brewery = "Great Notion", Style = "IPA", Abv = 7 }
        );
    }
    public DbSet<Beer> Beers { get; set; }
  }
}