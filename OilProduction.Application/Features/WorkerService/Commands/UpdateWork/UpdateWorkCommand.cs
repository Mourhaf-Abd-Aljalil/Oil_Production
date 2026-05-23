using MediatR;
using OilProduction.Application.Features.WorkService.Queries.GetWorksList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilProduction.Application.Features.WorkService.Commands.UpdateWork
{
    public class UpdateWorkCommand 
    {
        public int WorkerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
   
    }
}
