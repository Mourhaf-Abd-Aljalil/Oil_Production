namespace OilProduction.Domain.Entities.CropLand
{
    public class PressOrders : BaseModel
    {
        public long CropId { get; set; }
        public long PressId { get; set; }
        public long MealId { get; set; }
        public double OrderQuantity { get; set; }
    }
}
