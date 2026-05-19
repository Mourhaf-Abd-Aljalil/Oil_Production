using OilProduction.Domain.Entities.WorkTeam;
using System.Net.Sockets;

namespace OilProduction.Domain.Entities.FarmTree
{
    public class TreeFarmTeam : BaseModel
    {
        public long TeamId { get; set; }
        public Team Team { get; set; }
        public long TreeFarmId {  get; set; }
        public TreesFarms TreesFarms { get; set; }
        public bool IsCrop {  get; set; }
        public double AmountCollected { get; set; }
    }
}
