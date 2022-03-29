namespace BeerApi.Models
{
  public class Beer
  {
    public int BeerId { get; set; }
    public string Name { get; set; }
    public string Brewery { get; set; }
    public string Style { get; set; }
    public double Abv { get; set; }
  }
}