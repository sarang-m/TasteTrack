using System;
using System.Collections.Generic;
using TasteTrack.Entities;

namespace TasteTrack.ServiceContracts.DTO
{
    public class RestaurantAddRequest
    {
        public string? RestaurantName { get; set; }
        public string? RestaurantLocation { get; set; }

        public Restaurant ToRestaurant()
        {

            return new Restaurant() { 
                RestaurantName = RestaurantName,
                RestaurantLocation = RestaurantLocation
            };


        }
    }
}
