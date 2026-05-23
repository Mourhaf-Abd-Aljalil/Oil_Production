using Microsoft.EntityFrameworkCore;
using OilProduction.Application.Contracts;
using OilProduction.Application.Features.WorkService.Queries.GetWorksList;
using OilProduction.Domain.Entities.WorkTeam;
using RAG.Service.Abstractions.Handlers;

namespace OilProduction.Application.Features.JobService.Commands.UpdateJob
{
    public class UpdateJobHandler : IRequestHandler<UpdateJobRequest, JobDto>
    {
        private readonly IJobRepository _bOperationService;

        public UpdateJobHandler(IJobRepository dbOperationService)
        {
            _bOperationService = dbOperationService;
        }
        public async Task<JobDto> HandleAsync(UpdateJobRequest request, CancellationToken cancellationToken = default)
        {
          var model = await _bOperationService.Set<Job>()
                .FirstOrDefaultAsync(j => j.Id == request.JobId && j.IsValid , cancellationToken)
                ?? throw new InvalidOperationException("JobIsNotFound");

            model.JobType = request.Type;

            await _bOperationService.SaveAsync();

            var dto = new JobDto
            {
                Id = model.Id,
                JobType = model.JobType,
            };


            return dto;
        }
    }
}
