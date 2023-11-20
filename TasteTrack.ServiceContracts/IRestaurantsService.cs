using TasteTrack.ServiceContracts.DTO;

namespace TasteTrack.ServiceContracts
{
    public interface IRestaurantsService
    {
        public RestaurantResponse AddRestaurant(RestaurantAddRequest restaurantAddRequest);
        public List<RestaurantResponse> GetAllRestaurants();
        public RestaurantResponse GetRestaurantByID(Guid restaurantID);

    }
}