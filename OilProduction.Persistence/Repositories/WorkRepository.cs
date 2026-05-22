using Microsoft.EntityFrameworkCore;
using OilProduction.Application.Contracts;
using OilProduction.Domain.Entities.WorkTeam;
using OilProduction.Persistence.Data;

namespace OilProduction.Persistence.Repositories
{
    public class WorkRepository : BaseRepository<Worker>, IWorkRepository
    {
        private readonly OilProductionDbContext _context;
        public WorkRepository(OilProductionDbContext context) : base(context) 
        {

        }

        public async Task DeleteAsync(Worker work)
        {
          await DeleteAsync(work);
        }

        public async Task<IReadOnlyList<Worker>> GetAllWorksAsync(bool includeJob = false)
        {
            List<Worker> Works = new List<Worker>();

            Works = includeJob ? await _context.Works.Include(J => J.Job).ToListAsync() : await _context.Works.ToListAsync();

            return Works;
        }

        public async Task<Worker> GetWorkByIdAsync(int id, bool includeJob = false)
        {
            
            Worker Work = new Worker();

            Work = includeJob ? await _context.Set<Worker>().Include(J => J.Job).FirstOrDefaultAsync(x => x.Id == id) : await _context.Set<Worker>().FirstOrDefaultAsync(e => e.Id == id);

            return Work;
            
        }
    }
}
