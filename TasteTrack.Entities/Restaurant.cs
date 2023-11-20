namespace TasteTrack.Entities
{
    public class Restaurant
    {
        //Domain Model for Restaurant
        public Guid RestaurantId { get; set; }   
        public string? RestaurantName { get; set; }
        public string? RestaurantLocation { get; set; }

    }
}