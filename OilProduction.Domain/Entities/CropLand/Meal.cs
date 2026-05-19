namespace OilProduction.Domain.Entities.CropLand
{
    public class Meal : BaseModel
    {
        public double TotalMealProduction { get; set; }
        public ICollection<PressOrders> PressOrders { get; set; } = [];
    }
}
