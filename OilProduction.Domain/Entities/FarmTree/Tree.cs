namespace OilProduction.Domain.Entities.FarmTree
{
    public class Tree : BaseModel
    {
        public string Type { get; set; }
        public ICollection<TreesFarms> TreeFarmsT { get; set; } = [];
    }
}
