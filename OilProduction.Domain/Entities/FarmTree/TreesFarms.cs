using OilProduction.Domain.Entities.CropLand;

namespace OilProduction.Domain.Entities.FarmTree
{
    public class TreesFarms : BaseModel
    {
        public long FarmId { get; set; }
        public Farm Farm { get; set; }
        public long TreeId { get; set; }
        public Tree Tree { get; set; }
        public DateTime DatePlanted { get; set; }
        public double UsedPersentage { get; set; }
        public int TreeSpacing { get; set; }
        public ICollection<TreeFarmTeam> TreeFarmTeams { get; set; } = [];
        public ICollection<Crop> Crops { get; set; } = [];
        public ICollection<TreeFarmFertilizer> TreeFarmFertilizers { get; set; } = [];
    }
}
