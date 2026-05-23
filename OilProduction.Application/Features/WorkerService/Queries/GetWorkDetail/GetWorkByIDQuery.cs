using MediatR;


namespace OilProduction.Application.Features.WorkService.Queries.GetWorkDetail
{
    public class GetWorkByIDQuery : IRequest<WorkRequest>
    {
        public int Id { get; set; }
    }
}
