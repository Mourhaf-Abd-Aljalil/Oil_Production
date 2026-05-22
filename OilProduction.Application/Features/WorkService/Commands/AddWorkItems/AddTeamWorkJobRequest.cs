

namespace OilProduction.Application.Features.WorkService.Commands.AddWorkItems
{
    public class AddTeamWorkJobRequest : AddItemRequest
    {
        public List<AddTeamWorkJobDto> TeamWorkJobItems { get; set; }
        public AddTeamWorkJobRequest(List<AddTeamWorkJobDto> TeamWorkJob ,int WorkId) : base(WorkId)
        {
            TeamWorkJobItems = TeamWorkJob ;
        }
    }
}
