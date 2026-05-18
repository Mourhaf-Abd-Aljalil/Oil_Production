using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilProduction.Domain.Entities
{
    public class BaseModel
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public bool IsValid { get; set; } = true;
    }
}
