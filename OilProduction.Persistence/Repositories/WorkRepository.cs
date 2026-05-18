using Microsoft.EntityFrameworkCore;
using OilProduction.Application.Contracts;
using OilProduction.Domain;
using OilProduction.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilProduction.Persistence.Repositories
{
    public class WorkRepository : BaseRepository<WorkModel>, IWorkRepository
    {
        private readonly OilProductionDbContext _context;
        public WorkRepository(OilProductionDbContext context) : base(context) 
        {

        }

        public async Task DeleteAsync(WorkModel work)
        {
          await DeleteAsync(work);
        }

        public async Task<IReadOnlyList<WorkModel>> GetAllWorksAsync(bool includeJob = false)
        {
            List<WorkModel> Works = new List<WorkModel>();

            Works = includeJob ? await _context.Works.Include(J => J.Job).ToListAsync() : await _context.Works.ToListAsync();

            return Works;
        }

        public async Task<WorkModel> GetWorkByIdAsync(int id, bool includeJob = false)
        {
            
            WorkModel Work = new WorkModel();

            Work = includeJob ? await _context.Works.Include(J => J.Job).FirstOrDefaultAsync(x => x.Id == id) : await GetByIdAsync(id);

            return Work;
            
        }
    }
}
