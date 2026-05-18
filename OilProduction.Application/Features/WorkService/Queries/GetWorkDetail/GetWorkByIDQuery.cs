using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilProduction.Application.Features.WorkService.Queries.GetWorkDetail
{
    public class GetWorkByIDQuery : IRequest<WorkRequest>
    {
        public int Id { get; set; }
    }
}
