namespace OilProduction.Domain.Entities.CropLand
{
    public class PressOrders : BaseModel
    {
        public long CropId { get; set; }
        public Crop Crop { get; set; }
        public long PressId { get; set; }
        public Presses Presses { get; set; }
        public long MealId { get; set; }
        public Meal Meal { get; set; }
        public double OrderQuantity { get; set; }
    }
}
