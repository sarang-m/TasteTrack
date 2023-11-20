using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteTrack.Entities;

namespace TasteTrack.ServiceContracts.DTO
{
    public class FoodItemResponse
    {
        public Guid FoodItemId { get; set; }
        public string? FoodName { get; set; }
        public string? FoodDescription { get; set; }
        public int FoodPrice { get; set; }

        public static class FoodExtension
        {
            public static FoodItemResponse ToFoodItemResponse(FoodItem foodItem)
            {
                return new FoodItemResponse
                {
                    FoodItemId = foodItem.FoodItemId,
                    FoodName = foodItem.FoodName,
                    FoodPrice = foodItem.FoodPrice,
                    FoodDescription = foodItem.FoodDescription,
                };
            }
        }
    }
}
