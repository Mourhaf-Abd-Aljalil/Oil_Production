using Microsoft.EntityFrameworkCore;
using OilProduction.Application.Contracts;
using OilProduction.Application.Features.WorkService.Queries.GetWorksList;
using OilProduction.Domain.Entities.WorkTeam;
using RAG.Service.Abstractions.Handlers;


namespace OilProduction.Application.Features.JobService.Queries.GetJobById
{
    public class GetJobByIdHandler : IRequestHandler<GetJobByIdRequest ,JobDto>
    {
        private readonly IJobRepository _dbOperationService;
        public GetJobByIdHandler(IJobRepository dbOperationService)
        {
            _dbOperationService = dbOperationService;
        }

        public async Task<JobDto> HandleAsync(GetJobByIdRequest request, CancellationToken cancellationToken = default)
        {
            var model = await _dbOperationService.Set<Job>()
                  .FirstOrDefaultAsync(j => j.Id == request.JobId && j.IsValid, cancellationToken)
                  ?? throw new InvalidOperationException("JobIsNotFound");
            
            if(model != null)
            {
                JobDto dto = new JobDto()
                {
                    Id = model.Id,
                    JobType = model.JobType,
                };
                return dto;
            }
            throw new InvalidOperationException("InvalidRequest");
        }
    }
}
