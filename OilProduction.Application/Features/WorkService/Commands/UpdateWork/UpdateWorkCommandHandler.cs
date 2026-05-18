using AutoMapper;
using MediatR;
using OilProduction.Application.Contracts;
using OilProduction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilProduction.Application.Features.WorkService.Commands.UpdateWork
{
    public class UpdateWorkCommandHandler : IRequestHandler<UpdateWorkCommand>
    {
        private readonly IWorkRepository _WorkRepository;
        private readonly IMapper _mapper;

        public UpdateWorkCommandHandler(IWorkRepository workRepository, IMapper mapper)
        {
            _WorkRepository = workRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateWorkCommand request, CancellationToken cancellationToken)
        {
            WorkModel work = _mapper.Map<WorkModel>(request);

            await _WorkRepository.UpdateAsync(work);

            return Unit.Value;
        }
    }
}
