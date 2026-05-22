

namespace OilProduction.Application.Features.WorkService.Commands.AddWorkItems
{
    public class AddTeamWorkerRequest : AddItemRequest
    {
        public List<AddTeamWorkerDto> TeamWorks { get; set; }
        public AddTeamWorkerRequest(List<AddTeamWorkerDto> TeamWorks ,int WorkId) : base(WorkId)
        {
            this.TeamWorks = TeamWorks;
        }
    }
}
