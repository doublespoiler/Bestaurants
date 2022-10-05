namespace BestRestaurants.Models
{
  public class Restaurant 
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public int Rating { get; set; }
    public int Cost { get; set; }
    public string Review { get; set; }
    public int TypeId { get; set; }
    public virtual Type Type { get; set; }
  }
}