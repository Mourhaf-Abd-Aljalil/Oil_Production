

namespace OilProduction.Domain.Entities.CropLand
{
    public class Presses
    {
        public string Name { get; set; }
        public double Capacity { get; set; }
        public string Location { get; set; }
        public ICollection<PressOrders> PressOrders { get; set; } = [];
    }
}
