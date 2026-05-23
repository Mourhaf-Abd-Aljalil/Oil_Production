

using MediatR;
using OilProduction.Application.Features.WorkService.Queries.GetWorksList;

namespace OilProduction.Application.Features.JobService.Queries.GetJobById
{
    public class GetJobByIdRequest 
    {
        public int JobId { get; set; }
    }
}
