using AutoMapper;
using MediatR;
using OilProduction.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilProduction.Application.Features.WorkService.Commands.DeleteWork
{
    public class DeleteWorkCommandHandler : IRequestHandler<DeleteWorkCommand>
    {

        private readonly IWorkRepository _WorkRepository;
        private readonly IMapper _mapper;

        public DeleteWorkCommandHandler(IWorkRepository workRepository, IMapper mapper)
        {
            _WorkRepository = workRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteWorkCommand request, CancellationToken cancellationToken)
        {
            var work = await _WorkRepository.GetWorkByIdAsync(request.Id);

            await _WorkRepository.DeleteAsync(work);

            return Unit.Value;
        }
    }
}
