

using MediatR;

namespace OilProduction.Application.Features.WorkService.Commands.AddWorkItems
{
    public class AddItemRequest : IRequest<int>
    {
        public int WorkId { get; set; }

        public AddItemRequest(int WorkId)
        {
            this.WorkId = WorkId;
        }
    }
}
