using TasteTrack.Entities;
using TasteTrack.ServiceContracts;
using TasteTrack.ServiceContracts.DTO;

namespace TasteTrack.Services
{
    public class RestaurentsService : IRestaurantsService
    {
        readonly List<Restaurant> _restaurants;
        public RestaurentsService()
        {
            _restaurants = new List<Restaurant>();
        }
        public RestaurantResponse AddRestaurant(RestaurantAddRequest restaurantAddRequest)
        {
            if (restaurantAddRequest == null)
            {
                throw new ArgumentNullException(nameof(restaurantAddRequest));
            }
            if (restaurantAddRequest.RestaurantName == null)
            {
                throw new ArgumentException(nameof(restaurantAddRequest.RestaurantName));
            }
            if (_restaurants.Where(
                restaurant => restaurant.RestaurantName == restaurantAddRequest.RestaurantName).Count() > 0)
            {
                throw new ArgumentException("Given restaurant name already exists");
            }
            Restaurant restaurant =  restaurantAddRequest.ToRestaurant();
            restaurant.RestaurantId = Guid.NewGuid();
            _restaurants.Add(restaurant);
            return restaurant.ToRestaurantResponse();
        }

        public List<RestaurantResponse> GetAllRestaurants()
        {
            List<RestaurantResponse> restaurantResponses = _restaurants.Select(
                restaurant => restaurant.ToRestaurantResponse()).ToList();
            return restaurantResponses;
        }


        public RestaurantResponse GetRestaurantByID(Guid restaurantID)
        {
            if (restaurantID == null)
            {
                return null;
            }
            Restaurant? restaurant = _restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == restaurantID);
            if (restaurant == null)
            {
                return null;
            }
            return restaurant.ToRestaurantResponse();
        }
    }
}