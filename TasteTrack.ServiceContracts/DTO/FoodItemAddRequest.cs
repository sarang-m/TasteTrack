using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteTrack.Entities;

namespace TasteTrack.ServiceContracts.DTO
{
    public class FoodItemAddRequest
    {
        public string? FoodName { get; set; }
        public string? FoodDescription {  get; set; }
        public int FoodPrice { get; set; }
        public FoodItem ToFood()
        {
            return new FoodItem()
            {
                FoodName = FoodName,
                FoodDescription = FoodDescription,
                FoodPrice = FoodPrice,

            };
        }
    }

    
}
