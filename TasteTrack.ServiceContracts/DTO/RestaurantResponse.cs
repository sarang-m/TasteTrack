using System;
using TasteTrack.Entities;

namespace TasteTrack.ServiceContracts.DTO
{
    public class RestaurantResponse
    {
        public Guid RestaurantId { get; set; }
        public string RestaurantName { get; set; }

        
    }
    public static class RestaurentExtensions
    {
        public static RestaurantResponse ToRestaurantResponse(this Restaurant restaurant)
        {
            return new RestaurantResponse()
            {
                RestaurantId = restaurant.RestaurantId,
                RestaurantName = restaurant.RestaurantName
            };
        }
    }
}
