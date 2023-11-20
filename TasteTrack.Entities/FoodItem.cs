using System;


namespace TasteTrack.Entities
{
    public class FoodItem
    {
        public Guid FoodItemId { get; set; }
        public string? FoodName { get; set;}
        public string? FoodDescription { get; set;}
        public int FoodPrice { get; set;}
    }
}
