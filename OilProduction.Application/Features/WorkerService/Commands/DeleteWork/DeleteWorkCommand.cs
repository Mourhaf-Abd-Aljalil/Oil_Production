using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilProduction.Application.Features.WorkService.Commands.DeleteWork
{
    public class DeleteWorkCommand : IRequest
    {
        public int Id { get; set; }
    }
}
