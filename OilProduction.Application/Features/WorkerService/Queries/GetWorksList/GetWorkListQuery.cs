using MediatR;


namespace OilProduction.Application.Features.WorkService.Queries.GetWorksList
{
    public class GetWorkListQuery : IRequest<List<WorksListRequest>>
    {
    }
}
