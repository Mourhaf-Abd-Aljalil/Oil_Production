using OilProduction.Application.Shared;
using OilProduction.Domain.Entities.FarmTree;

namespace OilProduction.Domain.Entities.WorkTeam
{
    public class Team : BaseModel
    {
        public ETeamType TeamType { get; set; }
        public string TeamName { get; set; }
        public ICollection<TeamWork> TeamWork { get; set; } = [];
        public ICollection<TeamWorkJob> TeamWorkJobs { get; set; } = [];
        public ICollection<TreeFarmTeam> TreeFarmTeam { get; set; } = [];
    }
}
