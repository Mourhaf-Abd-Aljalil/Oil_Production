using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OilProduction.Application.Contracts;
using OilProduction.Application.Features.WorkService.Queries.GetWorksList;
using OilProduction.Domain.Entities.WorkTeam;
using RAG.Service.Abstractions.Handlers;


namespace OilProduction.Application.Features.WorkService.Commands.UpdateWork
{
    public class UpdateWorkCommandHandler : IRequestHandler<UpdateWorkCommand, Worker>
    {
        private readonly IWorkRepository _WorkRepository;


        public UpdateWorkCommandHandler(IWorkRepository workRepository, IMapper mapper)
        {
            _WorkRepository = workRepository;
        }

        public async Task<Worker> HandleAsync(UpdateWorkCommand request, CancellationToken cancellationToken = default)
        {
            var model = await _WorkRepository.Set<Worker>()
                .FirstOrDefaultAsync(J => J.Id == request.WorkerId && J.IsValid, cancellationToken)
                ?? throw new InvalidOperationException("WorkerIsNotFound");

            model.Name = request.Name;
            model.Address = request.Address;
            model.PhoneNumber = request.PhoneNumber;

            await _WorkRepository.SaveAsync();

            return model;
        }
    }
}
