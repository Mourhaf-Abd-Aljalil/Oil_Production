using Microsoft.EntityFrameworkCore;
using OilProduction.Application.Contracts;
using OilProduction.Application.Features.WorkService.Queries.GetWorksList;
using OilProduction.Domain.Entities.WorkTeam;
using RAG.Service.Abstractions.Handlers;

namespace OilProduction.Application.Features.JobService.Commands.DeactivateJob
{
    public class DeactivateJobHandler : IRequestHandler<DeactivateJobRequest, JobDto>
    {
        private readonly IJobRepository _dbOperationService;

        public DeactivateJobHandler(IJobRepository dbOperationService)
        {
            _dbOperationService = dbOperationService;
        }
        public async Task<JobDto> HandleAsync(DeactivateJobRequest request, CancellationToken cancellationToken = default)
        {
            var model = await _dbOperationService.Set<Job>()
                  .FirstOrDefaultAsync(j => j.Id == request.JobId && j.IsValid, cancellationToken)
                  ?? throw new InvalidOperationException("JobIsNotFound");

            model.IsValid = false;

            await _dbOperationService.SaveAsync();

            var dto = new JobDto
            {
                Id = model.Id,
                JobType = model.JobType,
            };

            return dto;
        }
    }
}

