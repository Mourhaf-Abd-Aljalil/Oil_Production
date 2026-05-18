using OilProduction.Application.Shared;

namespace OilProduction.Domain.Entities.WorkTeam
{
    public class TeamModel : BaseModel
    {
        public ETeamType TeamType { get; set; }
        public string TeamName { get; set; }
    }
}
