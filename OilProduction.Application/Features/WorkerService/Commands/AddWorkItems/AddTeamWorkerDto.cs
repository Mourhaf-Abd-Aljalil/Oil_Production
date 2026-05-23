
using OilProduction.Domain.Entities.WorkTeam;

namespace OilProduction.Application.Features.WorkService.Commands.AddWorkItems
{
    public class AddTeamWorkerDto
    {
        public long WorkId { get; set; }
        public bool IsManeger { get; set; }
    }
}
